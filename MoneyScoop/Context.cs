using Database;
using MoneyScoop.Model;
using MoneyScoop.Utils;
using System;
using System.Diagnostics;

namespace MoneyScoop
{
    public class Context
    {
        #region Constants
        private const string SECTION_MAIN = "Main";
        private const string KEY_DEBUG = "Debug";
        private const string KEY_MAX_OBJECT_CODE_LENGTH = "MaxObjectCodeLength";
        private const string KEY_MIN_OBJECT_CODE_LENGTH = "MinObjectCodeLength";
        private const string KEY_MAX_OBJECT_DESC_LENGTH = "MaxObjectDescLength";
        private const string KEY_MAX_OBJECT_INFO_LENGTH = "MaxObjectInfoLength";
        private const string KEY_DUE_DAYS = "DueDays";
        private const string KEY_SAVE_PATH = "SavePdfPath";
        private const string KEY_READ_PATH = "ReadPdfPath";
        private const string KEY_BOOKY_PATH = "BookyPdfPath";

        private const string SECTION_DATABASE = "Database";
        private const string KEY_DB_SERVER = "DbServer";
        private const string KEY_DB_SCHEMA = "DbSchema";
        private const string KEY_DB_USER = "DbUser";
        private const string KEY_DB_PASSWORD = "DbPassword";
        private const string KEY_DB_PROVIDER = "Provider";

        private const string SECTION_INFO = "Info";
        private const string KEY_INFO_NAME = "Name";
        private const string KEY_INFO_ADR1 = "AdressLine1";
        private const string KEY_INFO_ADR2 = "AdressLine2";
        private const string KEY_INFO_VAT = "VAT";
        private const string KEY_INFO_EMAIL = "Email";
        private const string KEY_INFO_PHONE = "Phone";
        private const string KEY_INFO_BANK = "BankAccount";

        private const string SECTION_MAIL = "Mail";
        private const string KEY_MAIL_EMAIL = "Email";
        private const string KEY_MAIL_SMTP_SERVER = "SMTPServer";
        private const string KEY_MAIL_SMTP_PORT = "SMTPPort";
        private const string KEY_MAIL_SMTP_USER = "SMTPUser";
        private const string KEY_MAIL_SMTP_PASSWORD = "SMTPPassword";

        private const string SECTION_BOOK_KEEPER = "BookKeeper";
        private const string KEY_BOOKEY_NAME = "Name";
        private const string KEY_BOOKEY_COMPANY = "Company";
        private const string KEY_BOOKEY_INFO = "Info";
        private const string KEY_BOOKEY_EMAIL = "Email";
        private const string KEY_BOOKEY_PHONE = "Phone";
        private const string KEY_BOOKEY_VAT = "VAT";
        private const string KEY_BOOKEY_BANK_ACCOUNT = "BankAccount";
        #endregion


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
        private string bookyPdfPath;
        private int dueDays;

        // Mail
        private string email;
        private string sMTPServer;
        private int sMTPPort;
        private string sMTPUser;
        private string sMTPPassword;

        // Booky
        public BookKeeper BookKeeper { get; private set; }

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

        #region Read ini file

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

            BookKeeper = new BookKeeper()
            {
                Name = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_NAME),
                Company = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_COMPANY),
                Info = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_INFO),
                Email = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_EMAIL),
                Phone = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_PHONE),
                VAT = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_VAT),
                BankAccount = iniFile.ReadString(SECTION_BOOK_KEEPER, KEY_BOOKEY_BANK_ACCOUNT)
            };

            Debug = iniFile.ReadBool(SECTION_MAIN, KEY_DEBUG);
            MaxObjectCodeLength = iniFile.ReadInt(SECTION_MAIN, KEY_MAX_OBJECT_CODE_LENGTH);
            MinObjectCodeLength = iniFile.ReadInt(SECTION_MAIN, KEY_MIN_OBJECT_CODE_LENGTH);
            MaxObjectDescLength = iniFile.ReadInt(SECTION_MAIN, KEY_MAX_OBJECT_DESC_LENGTH);
            MaxObjectInfoLength = iniFile.ReadInt(SECTION_MAIN, KEY_MAX_OBJECT_INFO_LENGTH);
            DueDays = iniFile.ReadInt(SECTION_MAIN, KEY_DUE_DAYS);
            SavePdfPath = iniFile.ReadString(SECTION_MAIN, KEY_SAVE_PATH);
            ReadPdfPath = iniFile.ReadString(SECTION_MAIN, KEY_READ_PATH);
            BookyPdfPath = iniFile.ReadString(SECTION_MAIN, KEY_BOOKY_PATH);

            Email = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_EMAIL);
            SMTPServer = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_SMTP_SERVER);
            SMTPPort = iniFile.ReadInt(SECTION_MAIL, KEY_MAIL_SMTP_PORT);
            SMTPUser = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_SMTP_USER);
            SMTPPassword = iniFile.ReadString(SECTION_MAIL, KEY_MAIL_SMTP_PASSWORD);
        }

        #endregion

        #region Properties

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

        public string BookyPdfPath
        {
            get => bookyPdfPath ?? "";
            set => bookyPdfPath = value;
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
