using Database;
using MoneyScoop.Model;
using MoneyScoop.Utils;
using System;
using System.Diagnostics;

namespace MoneyScoop
{
    public class Context
    {
        // Consts
        public const string SECTION_DATABASE = "Database";
        public const string KEY_DB_SERVER = "DbServer";
        public const string KEY_DB_SCHEMA = "DbSchema";
        public const string KEY_DB_USER = "DbUser";
        public const string KEY_DB_PASSWORD = "DbPassword";
        public const string KEY_DB_PROVIDER = "Provider";

        public const string SECTION_INFO = "Info";
        public const string KEY_INFO_NAME = "Name";
        public const string KEY_INFO_ADR1 = "AdressLine1";
        public const string KEY_INFO_ADR2 = "AdressLine2";
        public const string KEY_INFO_VAT = "VAT";
        public const string KEY_INFO_EMAIL = "Email";
        public const string KEY_INFO_PHONE = "Phone";
        public const string KEY_INFO_BANK = "BankAccount";

        public const int MAX_OBJECT_CODE_LENGTH = 45;
        public const int MIN_OBJECT_CODE_LENGTH = 4;
        public const int MAX_OBJECT_DESC_LENGTH = 255;
        public const int MAX_OBJECT_INFO_LENGTH = 1023;


        // Singleton
        private static readonly Context INSTANCE = new Context();
        public static Context Ctx { get { return INSTANCE; } }
        private Context() { }

        // Databases
        public DatabaseAccess Db { get; private set; }

        // Ini-file
        private IniFile iniFile;

        // My info
        public MyInfo MyInfo { get; private set; }

        #region Initialisation
        public void Initialize(IDatabaseAccess dbLogBack)
        {
            try
            {
                // Config
                iniFile = new IniFile(@"Config\settings.ini");
                InitializeSettings(iniFile);
                
                // Database
                InitializeDatabase(iniFile, dbLogBack);
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to initialize: " + e);
            }
        }

        public void Close()
        {
            // Database
            CloseDatabase();

        }
        #endregion

        #region Settings

        private void InitializeSettings(IniFile iniFile)
        {
            MyInfo = new MyInfo()
            {
                Name = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME),
                AddressLine1 = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME),
                AddressLine2 = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME),
                VATNumber = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME),
                Email = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME),
                Phone = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME),
                BankAccount = iniFile.ReadString(SECTION_INFO, KEY_INFO_NAME)
            };
        }

        #endregion

        #region Database

        private void InitializeDatabase(IniFile iniFile, IDatabaseAccess dbLogBack)
        {
            try
            {
                string server = iniFile.ReadString(SECTION_DATABASE, KEY_DB_SERVER);
                string schema = iniFile.ReadString(SECTION_DATABASE, KEY_DB_SCHEMA);
                string user = iniFile.ReadString(SECTION_DATABASE, KEY_DB_USER);
                string password = iniFile.ReadString(SECTION_DATABASE, KEY_DB_PASSWORD);
                string provider = iniFile.ReadString(SECTION_DATABASE, KEY_DB_PROVIDER);

                string connectionString = string.Format(DatabaseAccess.ConnectionString_MySQL,
                    server,
                    schema,
                    user,
                    password);

                Db = DatabaseAccess.CreateInstance("DataDb");
                Db.Initialize(dbLogBack,
                    connectionString,
                    provider,
                    schema);
            }
            catch (Exception e)
            {
                Debug.WriteLine("InitializeDatabase failed: " + e);
            }
        }

        private void CloseDatabase()
        {
            try
            {
                Db.CloseDown();
            }
            catch (Exception e)
            {
                Debug.WriteLine("CloseDatabase failed: " + e);
            }
        }

        #endregion
    }
}
