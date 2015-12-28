using System.Data;
using System;
using System.Data.Common;
using System.Configuration;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace OLSReadyToWed
{

    public abstract class ReadyToWed_DAO
    {

        private int _EventID;
        private string _DisplayName;
        private int _EventTypeID;
        private string _EventSummary;
        private string _VolunteerEmailTemplate;
        private string _ParticipantEmailTemplate;
        private DateTime _EventStartDate;
        private DateTime _EventEndDate;
        private bool _IsActive;
        private int _LocationID;
        private int _VolunteerHoursRequired;
        private int _VolunteerMinimum;
        private int _VolunteerLimit;
        private int _ParticipantMinimum;
        private int _ParticipantLimit;
        private DateTime _VolunteerTimeEntryDeadline;
        private int _QuotaHuntCategoryID;
        private DateTime _ApplicationOpenDate;
        private DateTime _ApplicationCloseDate;
        private int _LegacyQuotaLocationKey;
        private int _LegacyQuotaAlloted;
        private int _EmailTemplateID;
        private bool _LiveFiringClass;
        private int _PublicationProfileID;
        private bool _IsManuallyPublished;
        private string _LocationName;
        private string _LocationAddressStreet1;
        private string _LocationAddressStreet2;
        private string _LocationAddressZip5;
        private string _LocationAddressZip4;
        private string _URL;
        private string _ContactName;
        private string _ContactHomePhoneAreaCode;
        private string _ContactHomePhoneNumber;
        private string _ContactMobilePhoneAreaCode;
        private string _ContactMobilePhoneNumber;
        private string _ContactEmail;
        private string _Notes;
        private string _LocationCity;
        private string _LocationStateandTerritoriesID;
        private bool _isNew;

        #region  Constructors

        public ReadyToWed_DAO()
        {

            _EventID = 0;
            _QuotaHuntCategoryID = 0;
            _LegacyQuotaLocationKey = 0;
            _LegacyQuotaAlloted = 0;
            _EmailTemplateID = 0;
            _PublicationProfileID = 0;

        }

        public ReadyToWed_DAO(
        int EventID)
        {
            _EventID = EventID;

        }



        public ReadyToWed_DAO(int EventID, string DisplayName, int EventTypeID, string EventSummary, string VolunteerEmailTemplate, string ParticipantEmailTemplate, DateTime EventStartDate, DateTime EventEndDate, bool IsActive, int LocationID, int VolunteerHoursRequired, int VolunteerMinimum, int VolunteerLimit, int ParticipantMinimum, int ParticipantLimit, DateTime VolunteerTimeEntryDeadline, int QuotaHuntCategoryID, DateTime ApplicationOpenDate, DateTime ApplicationCloseDate, int LegacyQuotaLocationKey, int LegacyQuotaAlloted, int EmailTemplateID, bool LiveFiringClass, int PublicationProfileID, bool IsManuallyPublished, string LocationName, string LocationAddressStreet1, string LocationAddressStreet2, string LocationAddressZip5, string LocationAddressZip4, string URL, string ContactName, string ContactHomePhoneAreaCode, string ContactHomePhoneNumber, string ContactMobilePhoneAreaCode, string ContactMobilePhoneNumber, string ContactEmail, string Notes, string LocationCity, string LocationStateandTerritoriesID)
        {
            _EventID = EventID;
            _DisplayName = DisplayName;
            _EventTypeID = EventTypeID;
            _EventSummary = EventSummary;
            _VolunteerEmailTemplate = VolunteerEmailTemplate;
            _ParticipantEmailTemplate = ParticipantEmailTemplate;
            _EventStartDate = EventStartDate;
            _EventEndDate = EventEndDate;
            _IsActive = IsActive;
            _LocationID = LocationID;
            _VolunteerHoursRequired = VolunteerHoursRequired;
            _VolunteerMinimum = VolunteerMinimum;
            _VolunteerLimit = VolunteerLimit;
            _ParticipantMinimum = ParticipantMinimum;
            _ParticipantLimit = ParticipantLimit;
            _VolunteerTimeEntryDeadline = VolunteerTimeEntryDeadline;
            _QuotaHuntCategoryID = QuotaHuntCategoryID;
            _ApplicationOpenDate = ApplicationOpenDate;
            _ApplicationCloseDate = ApplicationCloseDate;
            _LegacyQuotaLocationKey = LegacyQuotaLocationKey;
            _LegacyQuotaAlloted = LegacyQuotaAlloted;
            _EmailTemplateID = EmailTemplateID;
            _LiveFiringClass = LiveFiringClass;
            _PublicationProfileID = PublicationProfileID;
            _IsManuallyPublished = IsManuallyPublished;
            _LocationName = LocationName;
            _LocationAddressStreet1 = LocationAddressStreet1;
            _LocationAddressStreet2 = LocationAddressStreet2;
            _LocationAddressZip5 = LocationAddressZip5;
            _LocationAddressZip4 = LocationAddressZip4;
            _URL = URL;
            _ContactName = ContactName;
            _ContactHomePhoneAreaCode = ContactHomePhoneAreaCode;
            _ContactHomePhoneNumber = ContactHomePhoneNumber;
            _ContactMobilePhoneAreaCode = ContactMobilePhoneAreaCode;
            _ContactMobilePhoneNumber = ContactMobilePhoneNumber;
            _ContactEmail = ContactEmail;
            _Notes = Notes;
            _LocationCity = LocationCity;
            _LocationStateandTerritoriesID = LocationStateandTerritoriesID;

        }

        #endregion

        #region Properties

        public int EventID
        {
            get
            {
                return _EventID;
            }


            set
            {
                _EventID = value;
            }

        }

        public string DisplayName
        {
            get
            {
                return _DisplayName;
            }


            set
            {
                _DisplayName = value;
            }

        }

        public int EventTypeID
        {
            get
            {
                return _EventTypeID;
            }


            set
            {
                _EventTypeID = value;
            }

        }

        public string EventSummary
        {
            get
            {
                return _EventSummary;
            }


            set
            {
                _EventSummary = value;
            }

        }

        public string VolunteerEmailTemplate
        {
            get
            {
                return _VolunteerEmailTemplate;
            }


            set
            {
                _VolunteerEmailTemplate = value;
            }

        }

        public string ParticipantEmailTemplate
        {
            get
            {
                return _ParticipantEmailTemplate;
            }


            set
            {
                _ParticipantEmailTemplate = value;
            }

        }

        public DateTime EventStartDate
        {
            get
            {
                return _EventStartDate;
            }


            set
            {
                _EventStartDate = value;
            }

        }

        public DateTime EventEndDate
        {
            get
            {
                return _EventEndDate;
            }


            set
            {
                _EventEndDate = value;
            }

        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }


            set
            {
                _IsActive = value;
            }

        }

        public int LocationID
        {
            get
            {
                return _LocationID;
            }


            set
            {
                _LocationID = value;
            }

        }

        public int VolunteerHoursRequired
        {
            get
            {
                return _VolunteerHoursRequired;
            }


            set
            {
                _VolunteerHoursRequired = value;
            }

        }

        public int VolunteerMinimum
        {
            get
            {
                return _VolunteerMinimum;
            }


            set
            {
                _VolunteerMinimum = value;
            }

        }

        public int VolunteerLimit
        {
            get
            {
                return _VolunteerLimit;
            }


            set
            {
                _VolunteerLimit = value;
            }

        }

        public int ParticipantMinimum
        {
            get
            {
                return _ParticipantMinimum;
            }


            set
            {
                _ParticipantMinimum = value;
            }

        }

        public int ParticipantLimit
        {
            get
            {
                return _ParticipantLimit;
            }


            set
            {
                _ParticipantLimit = value;
            }

        }

        public DateTime VolunteerTimeEntryDeadline
        {
            get
            {
                return _VolunteerTimeEntryDeadline;
            }


            set
            {
                _VolunteerTimeEntryDeadline = value;
            }

        }

        public int QuotaHuntCategoryID
        {
            get
            {
                return _QuotaHuntCategoryID;
            }


            set
            {
                _QuotaHuntCategoryID = value;
            }

        }

        public DateTime ApplicationOpenDate
        {
            get
            {
                return _ApplicationOpenDate;
            }


            set
            {
                _ApplicationOpenDate = value;
            }

        }

        public DateTime ApplicationCloseDate
        {
            get
            {
                return _ApplicationCloseDate;
            }


            set
            {
                _ApplicationCloseDate = value;
            }

        }

        public int LegacyQuotaLocationKey
        {
            get
            {
                return _LegacyQuotaLocationKey;
            }


            set
            {
                _LegacyQuotaLocationKey = value;
            }

        }

        public int LegacyQuotaAlloted
        {
            get
            {
                return _LegacyQuotaAlloted;
            }


            set
            {
                _LegacyQuotaAlloted = value;
            }

        }

        public int EmailTemplateID
        {
            get
            {
                return _EmailTemplateID;
            }


            set
            {
                _EmailTemplateID = value;
            }

        }

        public bool LiveFiringClass
        {
            get
            {
                return _LiveFiringClass;
            }


            set
            {
                _LiveFiringClass = value;
            }

        }

        public int PublicationProfileID
        {
            get
            {
                return _PublicationProfileID;
            }


            set
            {
                _PublicationProfileID = value;
            }

        }

        public bool IsManuallyPublished
        {
            get
            {
                return _IsManuallyPublished;
            }


            set
            {
                _IsManuallyPublished = value;
            }

        }

        public string LocationName
        {
            get
            {
                return _LocationName;
            }


            set
            {
                _LocationName = value;
            }

        }

        public string LocationAddressStreet1
        {
            get
            {
                return _LocationAddressStreet1;
            }


            set
            {
                _LocationAddressStreet1 = value;
            }

        }

        public string LocationAddressStreet2
        {
            get
            {
                return _LocationAddressStreet2;
            }


            set
            {
                _LocationAddressStreet2 = value;
            }

        }

        public string LocationAddressZip5
        {
            get
            {
                return _LocationAddressZip5;
            }


            set
            {
                _LocationAddressZip5 = value;
            }

        }

        public string LocationAddressZip4
        {
            get
            {
                return _LocationAddressZip4;
            }


            set
            {
                _LocationAddressZip4 = value;
            }

        }

        public string URL
        {
            get
            {
                return _URL;
            }


            set
            {
                _URL = value;
            }

        }

        public string ContactName
        {
            get
            {
                return _ContactName;
            }


            set
            {
                _ContactName = value;
            }

        }

        public string ContactHomePhoneAreaCode
        {
            get
            {
                return _ContactHomePhoneAreaCode;
            }


            set
            {
                _ContactHomePhoneAreaCode = value;
            }

        }

        public string ContactHomePhoneNumber
        {
            get
            {
                return _ContactHomePhoneNumber;
            }


            set
            {
                _ContactHomePhoneNumber = value;
            }

        }

        public string ContactMobilePhoneAreaCode
        {
            get
            {
                return _ContactMobilePhoneAreaCode;
            }


            set
            {
                _ContactMobilePhoneAreaCode = value;
            }

        }

        public string ContactMobilePhoneNumber
        {
            get
            {
                return _ContactMobilePhoneNumber;
            }


            set
            {
                _ContactMobilePhoneNumber = value;
            }

        }

        public string ContactEmail
        {
            get
            {
                return _ContactEmail;
            }


            set
            {
                _ContactEmail = value;
            }

        }

        public string Notes
        {
            get
            {
                return _Notes;
            }


            set
            {
                _Notes = value;
            }

        }

        public string LocationCity
        {
            get
            {
                return _LocationCity;
            }


            set
            {
                _LocationCity = value;
            }

        }

        public string LocationStateandTerritoriesID
        {
            get
            {
                return _LocationStateandTerritoriesID;
            }


            set
            {
                _LocationStateandTerritoriesID = value;
            }

        }


        public bool IsNew
        {
            get
            {
                _isNew = System.Convert.ToBoolean(_EventID == 0); return _isNew;
            }

            set
            {
                _isNew = value;
            }

        }

        #endregion

        #region Custom Code

        protected DataSet DAOLoadMaxApplicationDateForQuotaHuntCategory(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_QuotaHuntCategories_GetMaxApplicationCloseDate";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, QuotaHuntCategoryID);
            return db.ExecuteDataSet(dbCommandWrapper);
        }


        protected DataSet DAOLoadAllEventsforLotteryQuotaHuntCategory(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_Events_ByQuotaHuntCategoryFromLottery";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, QuotaHuntCategoryID);
            return db.ExecuteDataSet(dbCommandWrapper);

        }

        protected DataSet DAOLoadLosersForLottery(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_ViewTemporaryLosers";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, QuotaHuntCategoryID);
            return db.ExecuteDataSet(dbCommandWrapper);

        }

        protected DataSet DAOLoadWinnersForLottery(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_ViewTemporaryWinners";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, QuotaHuntCategoryID);
            return db.ExecuteDataSet(dbCommandWrapper);

        }

        protected DataSet DAOLoadAllEventsforQuotaHuntCategory(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_Events_ByQuotaHuntCategory";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, QuotaHuntCategoryID);
            return db.ExecuteDataSet(dbCommandWrapper);

        }

        protected void DAORunLottery(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_RunLottery";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            dbCommandWrapper.CommandTimeout = 0;
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, QuotaHuntCategoryID);
            db.ExecuteNonQuery(dbCommandWrapper);

        }

        protected void DAOFinalizeLottery(int QuotaHuntCategoryID)
        {
            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_FinalizeLottery";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            dbCommandWrapper.CommandTimeout = 0;
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, QuotaHuntCategoryID);
            db.ExecuteNonQuery(dbCommandWrapper);

        }

        protected void DAOResetLottery(int QuotaHuntCategoryID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_LotteryResults_Reset";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, QuotaHuntCategoryID);

            db.ExecuteNonQuery(dbCommandWrapper);

        }

        protected bool DAOIsQuotaHunt(int EventID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_IsQuotaHunt";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, EventID);

            return Convert.ToBoolean(db.ExecuteScalar(dbCommandWrapper));

        }

        protected DataSet DAOViewEventPage(int EventId)
        {
            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_ViewEventPage";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@eventID", DbType.Int32, EventId);
            return db.ExecuteDataSet(dbCommandWrapper);
        }

        protected int DAODuplicateLotterySeason()
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_Lottery_DuplicateLastSeason";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            return Convert.ToInt32(db.ExecuteScalar(dbCommandWrapper));
        }

        protected DataSet DAOGetVolunteerParticipantCount(int EventId)
        {
            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_GetVolunteerParticipationCount";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@eventID", DbType.Int32, EventId);
            return db.ExecuteDataSet(dbCommandWrapper);
        }

        #endregion


        private DataSet LoadByPrimaryKey(int EventID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_Get";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, EventID);
            return db.ExecuteDataSet(dbCommandWrapper);

        }

        protected DataSet DAOLoadAll()
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_GetAll";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            return db.ExecuteDataSet(dbCommandWrapper);

        }

        protected System.Data.IDataReader DAOLoadAllReader()
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_GetAll";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            return db.ExecuteReader(dbCommandWrapper);

        }

        protected System.Data.IDataReader DAOGetList()
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_GetList";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            return db.ExecuteReader(dbCommandWrapper);

        }

        protected DataSet DAOSearch(object EventID, object DisplayName, object EventTypeID, object EventSummary, object VolunteerEmailTemplate, object ParticipantEmailTemplate, object EventStartDate, object EventEndDate, object IsActive, object LocationID, object VolunteerHoursRequired, object VolunteerMinimum, object VolunteerLimit, object ParticipantMinimum, object ParticipantLimit, object VolunteerTimeEntryDeadline, object QuotaHuntCategoryID, object ApplicationOpenDate, object ApplicationCloseDate, object LegacyQuotaLocationKey, object LegacyQuotaAlloted, object EmailTemplateID, object LiveFiringClass, object PublicationProfileID, object LocationName, object LocationAddressStreet1, object LocationAddressStreet2, object LocationAddressZip5, object LocationAddressZip4, object URL, object ContactName, object ContactHomePhoneAreaCode, object ContactHomePhoneNumber, object ContactMobilePhoneAreaCode, object ContactMobilePhoneNumber, object ContactEmail, object Notes, object LocationCity, object LocationStateandTerritoriesID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_Search";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, EventID);
            db.AddInParameter(dbCommandWrapper, "@paramDisplayName", DbType.AnsiString, SetNullValue(DisplayName.ToString() == "", DisplayName));
            db.AddInParameter(dbCommandWrapper, "@paramEventTypeID", DbType.Int32, EventTypeID);
            db.AddInParameter(dbCommandWrapper, "@paramEventSummary", DbType.AnsiString, SetNullValue(EventSummary.ToString() == "", EventSummary));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerEmailTemplate", DbType.AnsiString, VolunteerEmailTemplate);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantEmailTemplate", DbType.AnsiString, ParticipantEmailTemplate);
            db.AddInParameter(dbCommandWrapper, "@paramEventStartDate", DbType.DateTime, SetNullValue(EventStartDate.ToString() == "", EventStartDate));
            db.AddInParameter(dbCommandWrapper, "@paramEventEndDate", DbType.DateTime, SetNullValue(EventEndDate.ToString() == "", EventEndDate));
            db.AddInParameter(dbCommandWrapper, "@paramIsActive", DbType.Boolean, IsActive);
            db.AddInParameter(dbCommandWrapper, "@paramLocationID", DbType.Int32, SetNullValue(LocationID.ToString() == "0", LocationID));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerHoursRequired", DbType.Int32, SetNullValue(VolunteerHoursRequired.ToString() == "", VolunteerHoursRequired));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerMinimum", DbType.Int32, SetNullValue(VolunteerMinimum.ToString() == "", VolunteerMinimum));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerLimit", DbType.Int32, SetNullValue(VolunteerLimit.ToString() == "", VolunteerLimit));
            db.AddInParameter(dbCommandWrapper, "@paramParticipantMinimum", DbType.Int32, SetNullValue(ParticipantMinimum.ToString() == "", ParticipantMinimum));
            db.AddInParameter(dbCommandWrapper, "@paramParticipantLimit", DbType.Int32, SetNullValue(ParticipantLimit.ToString() == "", ParticipantLimit));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerTimeEntryDeadline", DbType.DateTime, SetNullValue(VolunteerTimeEntryDeadline.ToString() == "", VolunteerTimeEntryDeadline));
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, SetNullValue(QuotaHuntCategoryID.ToString() == "0", QuotaHuntCategoryID));
            db.AddInParameter(dbCommandWrapper, "@paramApplicationOpenDate", DbType.DateTime, SetNullValue(ApplicationOpenDate.ToString() == "", ApplicationOpenDate));
            db.AddInParameter(dbCommandWrapper, "@paramApplicationCloseDate", DbType.DateTime, SetNullValue(ApplicationCloseDate.ToString() == "", ApplicationCloseDate));
            db.AddInParameter(dbCommandWrapper, "@paramLiveFiringClass", DbType.Boolean, LiveFiringClass);
            db.AddInParameter(dbCommandWrapper, "@paramPublicationProfileID", DbType.Int32, SetNullValue(PublicationProfileID.ToString() == "", PublicationProfileID));
            db.AddInParameter(dbCommandWrapper, "@paramLocationName", DbType.AnsiString, LocationName);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressStreet1", DbType.AnsiString, LocationAddressStreet1);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressStreet2", DbType.AnsiString, LocationAddressStreet2);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressZip5", DbType.AnsiString, LocationAddressZip5);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressZip4", DbType.AnsiString, LocationAddressZip4);
            db.AddInParameter(dbCommandWrapper, "@paramURL", DbType.AnsiString, URL);
            db.AddInParameter(dbCommandWrapper, "@paramContactName", DbType.AnsiString, ContactName);
            db.AddInParameter(dbCommandWrapper, "@paramContactHomePhoneAreaCode", DbType.AnsiString, ContactHomePhoneAreaCode);
            db.AddInParameter(dbCommandWrapper, "@paramContactHomePhoneNumber", DbType.AnsiString, ContactHomePhoneNumber);
            db.AddInParameter(dbCommandWrapper, "@paramContactMobilePhoneAreaCode", DbType.AnsiString, ContactMobilePhoneAreaCode);
            db.AddInParameter(dbCommandWrapper, "@paramContactMobilePhoneNumber", DbType.AnsiString, ContactMobilePhoneNumber);
            db.AddInParameter(dbCommandWrapper, "@paramContactEmail", DbType.AnsiString, ContactEmail);
            db.AddInParameter(dbCommandWrapper, "@paramNotes", DbType.AnsiString, Notes);
            db.AddInParameter(dbCommandWrapper, "@paramLocationCity", DbType.AnsiString, LocationCity);
            db.AddInParameter(dbCommandWrapper, "@paramLocationStateandTerritoriesID", DbType.AnsiString, LocationStateandTerritoriesID);

            return db.ExecuteDataSet(dbCommandWrapper);
        }

        protected virtual void DAOLoad(int EventID)
        {

            DataSet ds = this.LoadByPrimaryKey(EventID);

            DataRow row = ds.Tables[0].Rows[0];
            _EventID = Convert.ToInt32(row["EventID"]);
            _DisplayName = Convert.ToString(row["DisplayName"]);
            _EventTypeID = Convert.ToInt32(row["EventTypeID"]);
            _EventSummary = Convert.ToString(row["EventSummary"]);
            _VolunteerEmailTemplate = Convert.ToString(row["VolunteerEmailTemplate"]);
            _ParticipantEmailTemplate = Convert.ToString(row["ParticipantEmailTemplate"]);
            _EventStartDate = Convert.ToDateTime(row["EventStartDate"]);
            _EventEndDate = Convert.ToDateTime(row["EventEndDate"]);
            _IsActive = Convert.ToBoolean(row["IsActive"]);
            if (row.IsNull("LocationID")) { _LocationID = 0; } else { _LocationID = Convert.ToInt32(row["LocationID"]); }
            _VolunteerHoursRequired = Convert.ToInt32(row["VolunteerHoursRequired"]);
            _VolunteerMinimum = Convert.ToInt32(row["VolunteerMinimum"]);
            _VolunteerLimit = Convert.ToInt32(row["VolunteerLimit"]);
            _ParticipantMinimum = Convert.ToInt32(row["ParticipantMinimum"]);
            _ParticipantLimit = Convert.ToInt32(row["ParticipantLimit"]);
            _VolunteerTimeEntryDeadline = Convert.ToDateTime(row["VolunteerTimeEntryDeadline"]);
            if (row.IsNull("QuotaHuntCategoryID")) { _QuotaHuntCategoryID = 0; } else { _QuotaHuntCategoryID = Convert.ToInt32(row["QuotaHuntCategoryID"]); }
            _ApplicationOpenDate = Convert.ToDateTime(row["ApplicationOpenDate"]);
            _ApplicationCloseDate = Convert.ToDateTime(row["ApplicationCloseDate"]);
            if (row.IsNull("LegacyQuotaLocationKey")) { _LegacyQuotaLocationKey = 0; } else { _LegacyQuotaLocationKey = Convert.ToInt32(row["LegacyQuotaLocationKey"]); }
            if (row.IsNull("LegacyQuotaAlloted")) { _LegacyQuotaAlloted = 0; } else { _LegacyQuotaAlloted = Convert.ToInt32(row["LegacyQuotaAlloted"]); }
            if (row.IsNull("EmailTemplateID")) { _EmailTemplateID = 0; } else { _EmailTemplateID = Convert.ToInt32(row["EmailTemplateID"]); }
            _LiveFiringClass = Convert.ToBoolean(row["LiveFiringClass"]);
            if (row.IsNull("PublicationProfileID")) { _PublicationProfileID = 0; } else { _PublicationProfileID = Convert.ToInt32(row["PublicationProfileID"]); }
            if (row.IsNull("IsManuallyPublished")) { _IsManuallyPublished = false; } else { _IsManuallyPublished = Convert.ToBoolean(row["IsManuallyPublished"]); }
            _LocationName = Convert.ToString(row["LocationName"]);
            _LocationAddressStreet1 = Convert.ToString(row["LocationAddressStreet1"]);
            _LocationAddressStreet2 = Convert.ToString(row["LocationAddressStreet2"]);
            _LocationAddressZip5 = Convert.ToString(row["LocationAddressZip5"]);
            _LocationAddressZip4 = Convert.ToString(row["LocationAddressZip4"]);
            _URL = Convert.ToString(row["URL"]);
            _ContactName = Convert.ToString(row["ContactName"]);
            _ContactHomePhoneAreaCode = Convert.ToString(row["ContactHomePhoneAreaCode"]);
            _ContactHomePhoneNumber = Convert.ToString(row["ContactHomePhoneNumber"]);
            _ContactMobilePhoneAreaCode = Convert.ToString(row["ContactMobilePhoneAreaCode"]);
            _ContactMobilePhoneNumber = Convert.ToString(row["ContactMobilePhoneNumber"]);
            _ContactEmail = Convert.ToString(row["ContactEmail"]);
            _Notes = Convert.ToString(row["Notes"]);
            _LocationCity = Convert.ToString(row["LocationCity"]);
            _LocationStateandTerritoriesID = Convert.ToString(row["LocationStateandTerritoriesID"]);

        }

        protected bool DAOSave()
        {

            if (this.IsNew)
            {
                return Insert();
            }
            else
            {
                return Update();
            }

        }


        private bool Insert()
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_Add";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);

            db.AddOutParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, 4);
            db.AddInParameter(dbCommandWrapper, "@paramDisplayName", DbType.AnsiString, _DisplayName);
            db.AddInParameter(dbCommandWrapper, "@paramEventTypeID", DbType.Int32, _EventTypeID);
            db.AddInParameter(dbCommandWrapper, "@paramEventSummary", DbType.AnsiString, _EventSummary);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerEmailTemplate", DbType.AnsiString, _VolunteerEmailTemplate);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantEmailTemplate", DbType.AnsiString, _ParticipantEmailTemplate);
            db.AddInParameter(dbCommandWrapper, "@paramEventStartDate", DbType.DateTime, _EventStartDate);
            db.AddInParameter(dbCommandWrapper, "@paramEventEndDate", DbType.DateTime, _EventEndDate);
            db.AddInParameter(dbCommandWrapper, "@paramIsActive", DbType.Boolean, _IsActive);
            db.AddInParameter(dbCommandWrapper, "@paramLocationID", DbType.Int32, SetNullValue(_LocationID == 0, _LocationID));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerHoursRequired", DbType.Int32, _VolunteerHoursRequired);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerMinimum", DbType.Int32, _VolunteerMinimum);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerLimit", DbType.Int32, _VolunteerLimit);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantMinimum", DbType.Int32, _ParticipantMinimum);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantLimit", DbType.Int32, _ParticipantLimit);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerTimeEntryDeadline", DbType.DateTime, _VolunteerTimeEntryDeadline);
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, SetNullValue(_QuotaHuntCategoryID == 0, _QuotaHuntCategoryID));
            db.AddInParameter(dbCommandWrapper, "@paramApplicationOpenDate", DbType.DateTime, _ApplicationOpenDate);
            db.AddInParameter(dbCommandWrapper, "@paramApplicationCloseDate", DbType.DateTime, _ApplicationCloseDate);
            db.AddInParameter(dbCommandWrapper, "@paramLegacyQuotaLocationKey", DbType.Int32, SetNullValue(_LegacyQuotaLocationKey == 0, _LegacyQuotaLocationKey));
            db.AddInParameter(dbCommandWrapper, "@paramLegacyQuotaAlloted", DbType.Int32, SetNullValue(_LegacyQuotaAlloted == 0, _LegacyQuotaAlloted));
            db.AddInParameter(dbCommandWrapper, "@paramEmailTemplateID", DbType.Int32, SetNullValue(_EmailTemplateID == 0, _EmailTemplateID));
            db.AddInParameter(dbCommandWrapper, "@paramLiveFiringClass", DbType.Boolean, _LiveFiringClass);
            db.AddInParameter(dbCommandWrapper, "@paramPublicationProfileID", DbType.Int32, SetNullValue(_PublicationProfileID == 0, _PublicationProfileID));
            db.AddInParameter(dbCommandWrapper, "@paramIsManuallyPublished", DbType.Boolean, _IsManuallyPublished);
            db.AddInParameter(dbCommandWrapper, "@paramLocationName", DbType.AnsiString, _LocationName);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressStreet1", DbType.AnsiString, _LocationAddressStreet1);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressStreet2", DbType.AnsiString, _LocationAddressStreet2);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressZip5", DbType.AnsiString, _LocationAddressZip5);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressZip4", DbType.AnsiString, _LocationAddressZip4);
            db.AddInParameter(dbCommandWrapper, "@paramURL", DbType.AnsiString, _URL);
            db.AddInParameter(dbCommandWrapper, "@paramContactName", DbType.AnsiString, _ContactName);
            db.AddInParameter(dbCommandWrapper, "@paramContactHomePhoneAreaCode", DbType.AnsiString, _ContactHomePhoneAreaCode);
            db.AddInParameter(dbCommandWrapper, "@paramContactHomePhoneNumber", DbType.AnsiString, _ContactHomePhoneNumber);
            db.AddInParameter(dbCommandWrapper, "@paramContactMobilePhoneAreaCode", DbType.AnsiString, _ContactMobilePhoneAreaCode);
            db.AddInParameter(dbCommandWrapper, "@paramContactMobilePhoneNumber", DbType.AnsiString, _ContactMobilePhoneNumber);
            db.AddInParameter(dbCommandWrapper, "@paramContactEmail", DbType.AnsiString, _ContactEmail);
            db.AddInParameter(dbCommandWrapper, "@paramNotes", DbType.AnsiString, _Notes);
            db.AddInParameter(dbCommandWrapper, "@paramLocationCity", DbType.AnsiString, _LocationCity);
            db.AddInParameter(dbCommandWrapper, "@paramLocationStateandTerritoriesID", DbType.AnsiString, _LocationStateandTerritoriesID);
            try
            {
                db.ExecuteNonQuery(dbCommandWrapper);
                object param;
                param = db.GetParameterValue(dbCommandWrapper, "@paramEventID");
                if (param == DBNull.Value) { return false; }

                _EventID = (int)param;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Update()
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_Update";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, _EventID);
            db.AddInParameter(dbCommandWrapper, "@paramDisplayName", DbType.AnsiString, _DisplayName);
            db.AddInParameter(dbCommandWrapper, "@paramEventTypeID", DbType.Int32, _EventTypeID);
            db.AddInParameter(dbCommandWrapper, "@paramEventSummary", DbType.AnsiString, _EventSummary);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerEmailTemplate", DbType.AnsiString, _VolunteerEmailTemplate);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantEmailTemplate", DbType.AnsiString, _ParticipantEmailTemplate);
            db.AddInParameter(dbCommandWrapper, "@paramEventStartDate", DbType.DateTime, _EventStartDate);
            db.AddInParameter(dbCommandWrapper, "@paramEventEndDate", DbType.DateTime, _EventEndDate);
            db.AddInParameter(dbCommandWrapper, "@paramIsActive", DbType.Boolean, _IsActive);
            db.AddInParameter(dbCommandWrapper, "@paramLocationID", DbType.Int32, SetNullValue(_LocationID == 0, _LocationID));
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerHoursRequired", DbType.Int32, _VolunteerHoursRequired);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerMinimum", DbType.Int32, _VolunteerMinimum);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerLimit", DbType.Int32, _VolunteerLimit);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantMinimum", DbType.Int32, _ParticipantMinimum);
            db.AddInParameter(dbCommandWrapper, "@paramParticipantLimit", DbType.Int32, _ParticipantLimit);
            db.AddInParameter(dbCommandWrapper, "@paramVolunteerTimeEntryDeadline", DbType.DateTime, _VolunteerTimeEntryDeadline);
            db.AddInParameter(dbCommandWrapper, "@paramQuotaHuntCategoryID", DbType.Int32, SetNullValue(_QuotaHuntCategoryID == 0, _QuotaHuntCategoryID));
            db.AddInParameter(dbCommandWrapper, "@paramApplicationOpenDate", DbType.DateTime, _ApplicationOpenDate);
            db.AddInParameter(dbCommandWrapper, "@paramApplicationCloseDate", DbType.DateTime, _ApplicationCloseDate);
            db.AddInParameter(dbCommandWrapper, "@paramEmailTemplateID", DbType.Int32, SetNullValue(_EmailTemplateID == 0, _EmailTemplateID));
            db.AddInParameter(dbCommandWrapper, "@paramLiveFiringClass", DbType.Boolean, _LiveFiringClass);
            db.AddInParameter(dbCommandWrapper, "@paramPublicationProfileID", DbType.Int32, SetNullValue(_PublicationProfileID == 0, _PublicationProfileID));
            db.AddInParameter(dbCommandWrapper, "@paramIsManuallyPublished", DbType.Boolean, _IsManuallyPublished);
            db.AddInParameter(dbCommandWrapper, "@paramLocationName", DbType.AnsiString, _LocationName);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressStreet1", DbType.AnsiString, _LocationAddressStreet1);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressStreet2", DbType.AnsiString, _LocationAddressStreet2);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressZip5", DbType.AnsiString, _LocationAddressZip5);
            db.AddInParameter(dbCommandWrapper, "@paramLocationAddressZip4", DbType.AnsiString, _LocationAddressZip4);
            db.AddInParameter(dbCommandWrapper, "@paramURL", DbType.AnsiString, _URL);
            db.AddInParameter(dbCommandWrapper, "@paramContactName", DbType.AnsiString, _ContactName);
            db.AddInParameter(dbCommandWrapper, "@paramContactHomePhoneAreaCode", DbType.AnsiString, _ContactHomePhoneAreaCode);
            db.AddInParameter(dbCommandWrapper, "@paramContactHomePhoneNumber", DbType.AnsiString, _ContactHomePhoneNumber);
            db.AddInParameter(dbCommandWrapper, "@paramContactMobilePhoneAreaCode", DbType.AnsiString, _ContactMobilePhoneAreaCode);
            db.AddInParameter(dbCommandWrapper, "@paramContactMobilePhoneNumber", DbType.AnsiString, _ContactMobilePhoneNumber);
            db.AddInParameter(dbCommandWrapper, "@paramContactEmail", DbType.AnsiString, _ContactEmail);
            db.AddInParameter(dbCommandWrapper, "@paramNotes", DbType.AnsiString, _Notes);
            db.AddInParameter(dbCommandWrapper, "@paramLocationCity", DbType.AnsiString, _LocationCity);
            db.AddInParameter(dbCommandWrapper, "@paramLocationStateandTerritoriesID", DbType.AnsiString, _LocationStateandTerritoriesID);

            try
            {
                db.ExecuteNonQuery(dbCommandWrapper);

                return true;

            }
            catch
            {
                return false;
            }

        }

        protected static void Remove(int EventID)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_Events_Delete";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramEventID", DbType.Int32, EventID);

            db.ExecuteNonQuery(dbCommandWrapper);

        }

        public string ToXml()
        {
            DataSet ds = this.LoadByPrimaryKey(_EventID);
            StringWriter writer = new StringWriter();
            ds.WriteXml(writer);
            return writer.ToString();

        }

        private object SetNullValue(bool isNullValue, object value)
        {

            if (isNullValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }

        }

    }
}

