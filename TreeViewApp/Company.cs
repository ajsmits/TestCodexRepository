using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TreeViewApp
{
    public sealed class Company
    {
        public Guid? CompanyID { get; set; }
        public string HostHeader { get; set; } = string.Empty;
        public string? CompanyName { get; set; }
        public string? ConnectionString_Live { get; set; }
        public string? ConnectionStringDescription_Live { get; set; }
        public string? ConnectionString_UAT { get; set; }
        public string? ConnectionStringDescription_UAT { get; set; }
        public string? DotLoopKey { get; set; }
        public string? DotLoopProfileIDs { get; set; }
        public bool? HasDocuSign { get; set; }
        public bool? HasZipForm { get; set; }
        public bool? ShowZipFormFieldsOnPropertyDetails { get; set; }
        public bool? ShowDocusignFieldsOnPropertyDetails { get; set; }
        public bool? IsActive { get; set; }
        public bool? HasMLSDownloadToPP { get; set; }
        public string? RecurringARApprovalEmail { get; set; }
        public string? Logo_Main { get; set; }
        public string? Main_HeaderTitle { get; set; }
        public string? Main_ColorBGPrimary { get; set; }
        public string? Main_ColorFontPrimary { get; set; }
        public string? Main_ColorBGSecondary { get; set; }
        public string? Main_ColorFontSecondary { get; set; }
        public string? Mobile_HeaderTitle { get; set; }
        public string? Mobile_ColorBGPrimary { get; set; }
        public string? Mobile_ColorFontPrimary { get; set; }
        public string? Mobile_ColorBGSecondary { get; set; }
        public string? Mobile_ColorFontSecondary { get; set; }
        public string? AuthNet_APILogin { get; set; }
        public bool? AuthNet_AllowCreditCardUpdate { get; set; }
        public bool? AuthNet_AllowCreditCardPayment { get; set; }
        public bool? HasAppFiles { get; set; }
        public bool? ShowAppFilesFieldsOnPropertyDetails { get; set; }
        public bool? HasSkySlope { get; set; }
        public bool? ShowSkySlopeFieldsOnPropertyDetails { get; set; }
        public int? ForceMFA { get; set; }
        public string? ActiveDirectoryPasswordResetDescription { get; set; }
        public int? ForceMFA_Associates { get; set; }
        public int IncludeInDataWarehouse { get; set; }
        public string? DepositLinkAPIClientID { get; set; }
        public string? DepositLinkAPISecret { get; set; }
        public string? PayloadAPIKey { get; set; }
        public bool? ImportClearedTransactions { get; set; }
        public bool? ImportPendingTransactions { get; set; }
        public string? TransactionDeskClientId { get; set; }
        public string? TransactionDeskClientSecret { get; set; }
        public string? DotLoopClientId { get; set; }
        public string? DotLoopClientSecret { get; set; }
        public string? DotLoopRefreshToken { get; set; }

        public static async System.Threading.Tasks.Task<IReadOnlyList<Company>> GetCompaniesAsync(
            string connectionString,
            Guid? companyId = null,
            bool includeBlankConString = true)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("WebUI_GetCompanies", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@CompanyID", SqlDbType.UniqueIdentifier).Value = (object?)companyId ?? DBNull.Value;
            command.Parameters.Add("@IncludeBlankConString", SqlDbType.Bit).Value = includeBlankConString;

            await connection.OpenAsync().ConfigureAwait(false);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);

            var companies = new List<Company>();
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                companies.Add(MapCompany(reader));
            }

            return companies;
        }

        private static Company MapCompany(SqlDataReader reader)
        {
            return new Company
            {
                CompanyID = GetValueOrDefault<Guid?>(reader, "CompanyID"),
                HostHeader = reader.GetString(reader.GetOrdinal("HostHeader")),
                CompanyName = GetString(reader, "CompanyName"),
                ConnectionString_Live = GetString(reader, "ConnectionString_Live"),
                ConnectionStringDescription_Live = GetString(reader, "ConnectionStringDescription_Live"),
                ConnectionString_UAT = GetString(reader, "ConnectionString_UAT"),
                ConnectionStringDescription_UAT = GetString(reader, "ConnectionStringDescription_UAT"),
                DotLoopKey = GetString(reader, "DotLoopKey"),
                DotLoopProfileIDs = GetString(reader, "DotLoopProfileIDs"),
                HasDocuSign = GetValueOrDefault<bool?>(reader, "HasDocuSign"),
                HasZipForm = GetValueOrDefault<bool?>(reader, "HasZipForm"),
                ShowZipFormFieldsOnPropertyDetails = GetValueOrDefault<bool?>(reader, "ShowZipFormFieldsOnPropertyDetails"),
                ShowDocusignFieldsOnPropertyDetails = GetValueOrDefault<bool?>(reader, "ShowDocusignFieldsOnPropertyDetails"),
                IsActive = GetValueOrDefault<bool?>(reader, "IsActive"),
                HasMLSDownloadToPP = GetValueOrDefault<bool?>(reader, "HasMLSDownloadToPP"),
                RecurringARApprovalEmail = GetString(reader, "RecurringARApprovalEmail"),
                Logo_Main = GetString(reader, "Logo_Main"),
                Main_HeaderTitle = GetString(reader, "Main_HeaderTitle"),
                Main_ColorBGPrimary = GetString(reader, "Main_ColorBGPrimary"),
                Main_ColorFontPrimary = GetString(reader, "Main_ColorFontPrimary"),
                Main_ColorBGSecondary = GetString(reader, "Main_ColorBGSecondary"),
                Main_ColorFontSecondary = GetString(reader, "Main_ColorFontSecondary"),
                Mobile_HeaderTitle = GetString(reader, "Mobile_HeaderTitle"),
                Mobile_ColorBGPrimary = GetString(reader, "Mobile_ColorBGPrimary"),
                Mobile_ColorFontPrimary = GetString(reader, "Mobile_ColorFontPrimary"),
                Mobile_ColorBGSecondary = GetString(reader, "Mobile_ColorBGSecondary"),
                Mobile_ColorFontSecondary = GetString(reader, "Mobile_ColorFontSecondary"),
                AuthNet_APILogin = GetString(reader, "AuthNet_APILogin"),
                AuthNet_AllowCreditCardUpdate = GetValueOrDefault<bool?>(reader, "AuthNet_AllowCreditCardUpdate"),
                AuthNet_AllowCreditCardPayment = GetValueOrDefault<bool?>(reader, "AuthNet_AllowCreditCardPayment"),
                HasAppFiles = GetValueOrDefault<bool?>(reader, "HasAppFiles"),
                ShowAppFilesFieldsOnPropertyDetails = GetValueOrDefault<bool?>(reader, "ShowAppFilesFieldsOnPropertyDetails"),
                HasSkySlope = GetValueOrDefault<bool?>(reader, "HasSkySlope"),
                ShowSkySlopeFieldsOnPropertyDetails = GetValueOrDefault<bool?>(reader, "ShowSkySlopeFieldsOnPropertyDetails"),
                ForceMFA = GetValueOrDefault<int?>(reader, "ForceMFA"),
                ActiveDirectoryPasswordResetDescription = GetString(reader, "ActiveDirectoryPasswordResetDescription"),
                ForceMFA_Associates = GetValueOrDefault<int?>(reader, "ForceMFA_Associates"),
                IncludeInDataWarehouse = reader.GetInt32(reader.GetOrdinal("IncludeInDataWarehouse")),
                DepositLinkAPIClientID = GetString(reader, "DepositLinkAPIClientID"),
                DepositLinkAPISecret = GetString(reader, "DepositLinkAPISecret"),
                PayloadAPIKey = GetString(reader, "PayloadAPIKey"),
                ImportClearedTransactions = GetValueOrDefault<bool?>(reader, "ImportClearedTransactions"),
                ImportPendingTransactions = GetValueOrDefault<bool?>(reader, "ImportPendingTransactions"),
                TransactionDeskClientId = GetString(reader, "TransactionDeskClientId"),
                TransactionDeskClientSecret = GetString(reader, "TransactionDeskClientSecret"),
                DotLoopClientId = GetString(reader, "DotLoopClientId"),
                DotLoopClientSecret = GetString(reader, "DotLoopClientSecret"),
                DotLoopRefreshToken = GetString(reader, "DotLoopRefreshToken")
            };
        }

        private static T? GetValueOrDefault<T>(IDataRecord record, string name)
        {
            var value = record[name];
            return value is DBNull ? default : (T)value;
        }

        private static string? GetString(IDataRecord record, string name)
        {
            var value = record[name];
            return value is DBNull ? null : (string)value;
        }
    }
}
