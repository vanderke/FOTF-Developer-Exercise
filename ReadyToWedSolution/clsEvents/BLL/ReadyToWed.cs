
using System;
using System.Data.Common;
using System.Data;

namespace OLSReadyToWed
{

    public class ReadyToWed : ReadyToWed_DAO
    {

        #region Constructors

        public ReadyToWed()
        {
        }

        public ReadyToWed(int EventID)
            : base(EventID)
        {
        }


        public ReadyToWed(int EventID, string DisplayName, int EventTypeID, string EventSummary, string VolunteerEmailTemplate, string ParticipantEmailTemplate, DateTime EventStartDate, DateTime EventEndDate, bool IsActive, int LocationID, int VolunteerHoursRequired, int VolunteerMinimum, int VolunteerLimit, int ParticipantMinimum, int ParticipantLimit, DateTime VolunteerTimeEntryDeadline, int QuotaHuntCategoryID, DateTime ApplicationOpenDate, DateTime ApplicationCloseDate, int LegacyQuotaLocationKey, int LegacyQuotaAlloted, int EmailTemplateID, bool LiveFiringClass, int PublicationProfileID, bool IsManuallyPublished, string LocationName, string LocationAddressStreet1, string LocationAddressStreet2, string LocationAddressZip5, string LocationAddressZip4, string URL, string ContactName, string ContactHomePhoneAreaCode, string ContactHomePhoneNumber, string ContactMobilePhoneAreaCode, string ContactMobilePhoneNumber, string ContactEmail, string Notes, string LocationCity, string LocationStateandTerritoriesID)
            : base(EventID, DisplayName, EventTypeID, EventSummary, VolunteerEmailTemplate, ParticipantEmailTemplate, EventStartDate, EventEndDate, IsActive, LocationID, VolunteerHoursRequired, VolunteerMinimum, VolunteerLimit, ParticipantMinimum, ParticipantLimit, VolunteerTimeEntryDeadline, QuotaHuntCategoryID, ApplicationOpenDate, ApplicationCloseDate, LegacyQuotaLocationKey, LegacyQuotaAlloted, EmailTemplateID, LiveFiringClass, PublicationProfileID, IsManuallyPublished, LocationName, LocationAddressStreet1, LocationAddressStreet2, LocationAddressZip5, LocationAddressZip4, URL, ContactName, ContactHomePhoneAreaCode, ContactHomePhoneNumber, ContactMobilePhoneAreaCode, ContactMobilePhoneNumber, ContactEmail, Notes, LocationCity, LocationStateandTerritoriesID)
        {
        }

        #endregion

        #region Custom Code

        public bool IsQuotaHunt(int EventID)
        {
            return base.DAOIsQuotaHunt(EventID);
        }

        public void RunLottery(int QuotaHuntCategoryID)
        {
            base.DAORunLottery(QuotaHuntCategoryID);
        }

        public void FinalizeLottery(int QuotaHuntCategoryID)
        {
            base.DAOFinalizeLottery(QuotaHuntCategoryID);
        }

        public void ResetLottery(int QuotaHuntCategoryID)
        {
            base.DAOResetLottery(QuotaHuntCategoryID);
        }

        public System.Data.DataSet LoadLosersForLotteryResults(int QuotaHuntCategoryID)
        {
            return base.DAOLoadLosersForLottery(QuotaHuntCategoryID);
        }

        public System.Data.DataSet LoadMaxApplicationDateForQuotaHuntCategory(int QuotaHuntCategoryID)
        {
            return base.DAOLoadMaxApplicationDateForQuotaHuntCategory(QuotaHuntCategoryID);
        }

        public System.Data.DataSet LoadWinnersForLotteryResults(int QuotaHuntCategoryID)
        {
            return base.DAOLoadWinnersForLottery(QuotaHuntCategoryID);
        }

        public System.Data.DataSet LoadEventsForLotteryResults(int QuotaHuntCategoryID)
        {
            return base.DAOLoadAllEventsforLotteryQuotaHuntCategory(QuotaHuntCategoryID);
        }

        public System.Data.DataSet LoadEventsForQuotaHuntCategory(int QuotaHuntCategoryID)
        {
            return base.DAOLoadAllEventsforQuotaHuntCategory(QuotaHuntCategoryID);
        }

        public DataSet ViewEventPage(int EventId)
        {
            return base.DAOViewEventPage(EventId);
        }

        public int DuplicateSeasons()
        {
            return base.DAODuplicateLotterySeason();
        }

        public DataSet GetVolunteerParticipantCount(int EventId)
        {
            return base.DAOGetVolunteerParticipantCount(EventId);
        }

        #endregion

        public System.Data.DataSet LoadAll()
        {

            return base.DAOLoadAll();
        }

        public System.Data.IDataReader LoadAllReader()
        {

            return base.DAOLoadAllReader();
        }


        public void Load(int EventID)
        {
            base.DAOLoad(EventID);
        }


        public DataSet Search(object EventID, object DisplayName, object EventTypeID, object EventSummary, object VolunteerEmailTemplate, object ParticipantEmailTemplate, object EventStartDate, object EventEndDate, object IsActive, object LocationID, object VolunteerHoursRequired, object VolunteerMinimum, object VolunteerLimit, object ParticipantMinimum, object ParticipantLimit, object VolunteerTimeEntryDeadline, object QuotaHuntCategoryID, object ApplicationOpenDate, object ApplicationCloseDate, object LegacyQuotaLocationKey, object LegacyQuotaAlloted, object EmailTemplateID, object LiveFiringClass, object PublicationProfileID, object LocationName, object LocationAddressStreet1, object LocationAddressStreet2, object LocationAddressZip5, object LocationAddressZip4, object URL, object ContactName, object ContactHomePhoneAreaCode, object ContactHomePhoneNumber, object ContactMobilePhoneAreaCode, object ContactMobilePhoneNumber, object ContactEmail, object Notes, object LocationCity, object LocationStateandTerritoriesID)
        {

            return base.DAOSearch(EventID, DisplayName, EventTypeID, EventSummary, VolunteerEmailTemplate, ParticipantEmailTemplate, EventStartDate, EventEndDate, IsActive, LocationID, VolunteerHoursRequired, VolunteerMinimum, VolunteerLimit, ParticipantMinimum, ParticipantLimit, VolunteerTimeEntryDeadline, QuotaHuntCategoryID, ApplicationOpenDate, ApplicationCloseDate, LegacyQuotaLocationKey, LegacyQuotaAlloted, EmailTemplateID, LiveFiringClass, PublicationProfileID, LocationName, LocationAddressStreet1, LocationAddressStreet2, LocationAddressZip5, LocationAddressZip4, URL, ContactName, ContactHomePhoneAreaCode, ContactHomePhoneNumber, ContactMobilePhoneAreaCode, ContactMobilePhoneNumber, ContactEmail, Notes, LocationCity, LocationStateandTerritoriesID);
        }


        public System.Data.IDataReader GetList()
        {

            return base.DAOGetList();
        }

        public bool Save()
        {

            return base.DAOSave();
        }

    }

}

