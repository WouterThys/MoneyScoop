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
        public const string SECTION_MAIN = "Main";
        public const string KEY_DEBUG = "Debug";
        public const string KEY_MAX_OBJECT_CODE_LENGTH = "MaxObjectCodeLength";
        public const string KEY_MIN_OBJECT_CODE_LENGTH = "MinObjectCodeLength";
        public const string KEY_MAX_OBJECT_DESC_LENGTH = "MaxObjectDescLength";
        public const string KEY_MAX_OBJECT_INFO_LENGTH = "MaxObjectInfoLength";
        public const string KEY_DUE_DAYS = "DueDays";
        public const string KEY_SAVE_PATH = "SavePdfPath";
        public const string KEY_READ_PATH = "ReadPdfPath";

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
        
        public const string SECTION_MAIL = "Mail";
        public const string KEY_MAIL_EMAIL = "Email";
        public const string KEY_MAIL_SMTP_SERVER = "SMTPServer";
        public const string KEY_MAIL_SMTP_PORT = "SMTPPort";
        public const string KEY_MAIL_SMTP_USER = "SMTPUser";
        public const string KEY_MAIL_SMTP_PASSWORD = "SMTPPassword";
        

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

        // Main
        private bool debug;
        private int maxObjectCodeLength;
        private int minObjectCodeLength;
        private int maxObjectDescLength;
        private int maxObjectInfoLength;

        // Save and read
        private string savePdfPath;
        private string readPdfPath;
        private int dueDays;

        // Mail
        private string email;
        private string sMTPServer;
        private int sMTPPort;
        private string sMTPUser;
        private string sMTPPassword;

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
                System.Diagnostics.Debug.WriteLine("Failed to initialize: " + e);
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
                AddressLine1 = iniFile.ReadString(SECTION_INFO, KEY_INFO_ADR1),
                AddressLine2 = iniFile.ReadString(SECTION_INFO, KEY_INFO_ADR2),
                VATNumber = iniFile.ReadString(SECTION_INFO, KEY_INFO_VAT),
                Email = iniFile.ReadString(SECTION_INFO, KEY_INFO_EMAIL),
                Phone = iniFile.ReadString(SECTION_INFO, KEY_INFO_PHONE),
                BankAccount = iniFile.ReadString(SECTION_INFO, KEY_INFO_BANK)
            };

            Debug = iniFile.ReadBool(SECTION_MAIN, KEY_DEBUG);
            MaxObjectCodeLength = iniFile.ReadInt(SECTION_MAIN, KEY_MAX_OBJECT_CODE_LENGTH);
            MinObjectCodeLength = iniFile.ReadInt(SECTION_MAIN, KEY_MIN_OBJECT_CODE_LENGTH);
            MaxObjectDescLength = iniFile.ReadInt(SECTION_MAIN, KEY_MAX_OBJECT_DESC_LENGTH);
            MaxObjectInfoLength = iniFile.ReadInt(SECTION_MAIN, KEY_MAX_OBJECT_INFO_LENGTH);
            DueDays = iniFile.ReadInt(SECTION_MAIN, KEY_DUE_DAYS);
            SavePdfPath = iniFile.ReadString(SECTION_MAIN, KEY_SAVE_PATH);
            ReadPdfPath = iniFile.ReadString(SECTION_MAIN, KEY_READ_PATH);

            Email = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_EMAIL);
            SMTPServer = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_SMTP_SERVER);
            SMTPPort = iniFile.ReadInt(SECTION_MAIL, KEY_MAIL_SMTP_PORT);
            SMTPUser = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_SMTP_USER);
            SMTPPassword = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_SMTP_PASSWORD);
        }

        public bool Debug
        {
            get => debug;
            set => debug = value;
        }

        public int MaxObjectCodeLength
        {
            get => maxObjectCodeLength;
            set => maxObjectCodeLength = value;
        }

        public int MinObjectCodeLength
        {
            get => minObjectCodeLength;
            set => minObjectCodeLength = value;
        }

        public int MaxObjectDescLength
        {
            get => maxObjectDescLength;
            set => maxObjectDescLength = value;
        }

        public int MaxObjectInfoLength
        {
            get => maxObjectInfoLength;
            set => maxObjectInfoLength = value;
        }

        public string SavePdfPath
        {
            get => savePdfPath ?? "";
            set => savePdfPath = value;
        }

        public string ReadPdfPath
        {
            get => readPdfPath ?? "";
            set => readPdfPath = value;
        }

        public int DueDays
        {
            get => dueDays;
            set => dueDays = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string SMTPServer
        {
            get => sMTPServer;
            set => sMTPServer = value;
        }

        public int SMTPPort
        {
            get => sMTPPort;
            set => sMTPPort = value;
        }

        public string SMTPUser
        {
            get => sMTPUser;
            set => sMTPUser = value;
        }

        public string SMTPPassword
        {
            get => sMTPPassword;
            set => sMTPPassword = value;
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
                System.Diagnostics.Debug.WriteLine("InitializeDatabase failed: " + e);
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
                System.Diagnostics.Debug.WriteLine("CloseDatabase failed: " + e);
            }
        }

        #endregion
    }
}
