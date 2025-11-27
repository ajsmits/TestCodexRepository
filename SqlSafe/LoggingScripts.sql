-- Table creation for execution logging
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'SqlSafe_ExecutionLog' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE dbo.SqlSafe_ExecutionLog
    (
        Id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_SqlSafe_ExecutionLog PRIMARY KEY,
        Environment NVARCHAR(50) NOT NULL,
        SqlServer NVARCHAR(200) NOT NULL,
        DatabaseName NVARCHAR(200) NOT NULL,
        [User] NVARCHAR(200) NOT NULL,
        BatchNumber INT NOT NULL CONSTRAINT DF_SqlSafe_ExecutionLog_BatchNumber DEFAULT (0),
        Success BIT NOT NULL,
        ScriptRan NVARCHAR(MAX) NOT NULL,
        ErrorMessage NVARCHAR(MAX) NULL,
        CreatedDate DATETIME2 NOT NULL CONSTRAINT DF_SqlSafe_ExecutionLog_CreatedDate DEFAULT (SYSUTCDATETIME())
    );
END
GO

-- Stored procedure to insert execution log records
IF OBJECT_ID('dbo.SqlSafe_LogExecution_Insert', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.SqlSafe_LogExecution_Insert;
END
GO

CREATE PROCEDURE dbo.SqlSafe_LogExecution_Insert
    @Environment NVARCHAR(50),
    @SqlServer NVARCHAR(200),
    @DatabaseName NVARCHAR(200),
    @User NVARCHAR(200),
    @BatchNumber INT,
    @Success BIT,
    @ScriptRan NVARCHAR(MAX),
    @ErrorMessage NVARCHAR(MAX) = NULL,
    @CreatedDate DATETIME2 = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @CreatedDate IS NULL
    BEGIN
        SET @CreatedDate = SYSUTCDATETIME();
    END

    INSERT INTO dbo.SqlSafe_ExecutionLog
    (
        Environment,
        SqlServer,
        DatabaseName,
        [User],
        BatchNumber,
        Success,
        ScriptRan,
        ErrorMessage,
        CreatedDate
    )
    VALUES
    (
        @Environment,
        @SqlServer,
        @DatabaseName,
        @User,
        @BatchNumber,
        @Success,
        @ScriptRan,
        @ErrorMessage,
        @CreatedDate
    );

    SELECT SCOPE_IDENTITY();
END
GO

-- Stored procedure to calculate the next batch number
IF OBJECT_ID('dbo.SqlSafe_LogExecution_GetNextBatch', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.SqlSafe_LogExecution_GetNextBatch;
END
GO

CREATE PROCEDURE dbo.SqlSafe_LogExecution_GetNextBatch
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NextBatch INT;

    SELECT @NextBatch = ISNULL(MAX(BatchNumber), 0) + 1
    FROM dbo.SqlSafe_ExecutionLog WITH (UPDLOCK, HOLDLOCK);

    SELECT @NextBatch AS BatchNumber;
END
GO

-- Stored procedure to list available batches
IF OBJECT_ID('dbo.SqlSafe_LogExecution_GetBatches', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.SqlSafe_LogExecution_GetBatches;
END
GO

CREATE PROCEDURE dbo.SqlSafe_LogExecution_GetBatches
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT BatchNumber
    FROM dbo.SqlSafe_ExecutionLog
    ORDER BY BatchNumber DESC;
END
GO

-- Stored procedure to retrieve logs for a given batch
IF OBJECT_ID('dbo.SqlSafe_LogExecution_GetByBatch', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.SqlSafe_LogExecution_GetByBatch;
END
GO

CREATE PROCEDURE dbo.SqlSafe_LogExecution_GetByBatch
    @BatchNumber INT = NULL,
    @DatabaseName NVARCHAR(200) = NULL,
    @Environment NVARCHAR(50) = NULL,
    @User NVARCHAR(200) = NULL,
    @CreatedFrom DATETIME2 = NULL,
    @CreatedTo DATETIME2 = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Id,
        Environment,
        SqlServer,
        DatabaseName,
        [User],
        BatchNumber,
        Success,
        ScriptRan,
        ErrorMessage,
        CreatedDate
    FROM dbo.SqlSafe_ExecutionLog
    WHERE (BatchNumber = @BatchNumber OR @BatchNumber IS NULL)
        AND (DatabaseName = @DatabaseName OR @DatabaseName IS NULL)
        AND (Environment = @Environment OR @Environment IS NULL)
        AND ([User] = @User OR @User IS NULL)
        AND (CreatedDate >= @CreatedFrom OR @CreatedFrom IS NULL)
        AND (CreatedDate <= @CreatedTo OR @CreatedTo IS NULL)
    ORDER BY CreatedDate DESC, Id DESC;
END
GO

-- Stored procedure to retrieve distinct filter options
IF OBJECT_ID('dbo.SqlSafe_LogExecution_GetFilterOptions', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.SqlSafe_LogExecution_GetFilterOptions;
END
GO

CREATE PROCEDURE dbo.SqlSafe_LogExecution_GetFilterOptions
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT DatabaseName
    FROM dbo.SqlSafe_ExecutionLog
    WHERE NULLIF(DatabaseName, '') IS NOT NULL
    ORDER BY DatabaseName;

    SELECT DISTINCT Environment
    FROM dbo.SqlSafe_ExecutionLog
    WHERE NULLIF(Environment, '') IS NOT NULL
    ORDER BY Environment;

    SELECT DISTINCT [User]
    FROM dbo.SqlSafe_ExecutionLog
    WHERE NULLIF([User], '') IS NOT NULL
    ORDER BY [User];
END
GO
