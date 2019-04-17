/* Title:           This is the phones Class
 * Date:            4-2-19
 * Author:          Terry Holmes
 * 
 * Description:     This is used as the class for the phones */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace PhonesDLL
{
    public class PhonesClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        PhoneListDataSet aPhoneListDataSet;
        PhoneListDataSetTableAdapters.phonelistTableAdapter aPhoneListTableAdapter;

        InsertPhoneEntryTableAdapters.QueriesTableAdapter aInsertPhoneTableAdapter;

        UpdateEmployeePhoneEntryTableAdapters.QueriesTableAdapter aUpdateEmployeePhoneTableAdapter;

        UpdatePhoneExtensionEntryTableAdapters.QueriesTableAdapter aUpdatePhoneExtensionTableAdapter;

        FindPhoneByExtensionDataSet aFindPhoneByExtensionDataSet;
        FindPhoneByExtensionDataSetTableAdapters.FindPhoneByExtensionTableAdapter aFindPhoneByExtensionTableAdapter;

        FindSortedPhoneListByExtensionDataSet aFindSortedPhoneListByExtensionDataSet;
        FindSortedPhoneListByExtensionDataSetTableAdapters.FindSortedPhoneListByExtensionTableAdapter aFindSortedPhoneListByExtensionTableAdapter;

        FindSortedExtensionsByLastNameDataSet aFindSortedExtensionsByLastNameDataSet;
        FindSortedExtensionsByLastNameDataSetTableAdapters.FindSortedExtensionsByLastNameTableAdapter aFindSortedExtensionsByLastNameTableAdapter;

        FindPhoneExtensionByEmployeeIDDataSet aFindPhoneExtensionByEmployeeIDDataSet;
        FindPhoneExtensionByEmployeeIDDataSetTableAdapters.FindPhoneExtensionByEmployeeIDTableAdapter aFindPhoneExtensionByEmployeeIDTableAdapter;

        FindPhoneExtensionsByLocationDataSet aFindPhoneExtensionsByLocationDataSet;
        FindPhoneExtensionsByLocationDataSetTableAdapters.FindPhoneExtensionsByLocationTableAdapter aFindPhoneExtensionsByLocationTableAdapter;

        CellPhoneListDataSet aCellPhoneListDataSet;
        CellPhoneListDataSetTableAdapters.cellphonelistTableAdapter aCellPhoneListTableAdapter;

        InsertCellPhoneEntryTableAdapters.QueriesTableAdapter aInsertCellPhoneTableAdapter;

        public bool InsertCellPhone(string strPhoneNumber, int intEmployeeID, int intWarehouseID, string strPhoneNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCellPhoneTableAdapter = new InsertCellPhoneEntryTableAdapters.QueriesTableAdapter();
                aInsertCellPhoneTableAdapter.InsertCellPhone(strPhoneNumnber, intEmployeeID, intWarehouseID, strPhoneNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Insert Cell Phone " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CellPhoneListDataSet GetCellPhoneListInfo()
        {
            try
            {
                aCellPhoneListDataSet = new CellPhoneListDataSet();
                aCellPhoneListTableAdapter = new CellPhoneListDataSetTableAdapters.cellphonelistTableAdapter();
                aCellPhoneListTableAdapter.Fill(aCellPhoneListDataSet.cellphonelist);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Get Cell Phone List Info " + Ex.Message);
            }

            return aCellPhoneListDataSet;
        }
        public void UpdateCellPhoneListDB (CellPhoneListDataSet aCellPhoneListDataSet)
        {
            try
            {
                aCellPhoneListTableAdapter = new CellPhoneListDataSetTableAdapters.cellphonelistTableAdapter();
                aCellPhoneListTableAdapter.Update(aCellPhoneListDataSet.cellphonelist);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Update Cell Phone List DB " + Ex.Message);
            }
        }
        public FindPhoneExtensionsByLocationDataSet FindPhoneExtensionByLocation(int intWarehouseID)
        {
            try
            {
                aFindPhoneExtensionsByLocationDataSet = new FindPhoneExtensionsByLocationDataSet();
                aFindPhoneExtensionsByLocationTableAdapter = new FindPhoneExtensionsByLocationDataSetTableAdapters.FindPhoneExtensionsByLocationTableAdapter();
                aFindPhoneExtensionsByLocationTableAdapter.Fill(aFindPhoneExtensionsByLocationDataSet.FindPhoneExtensionsByLocation, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Find Phone Extension By Location " + Ex.Message);
            }

            return aFindPhoneExtensionsByLocationDataSet;
        }
        public FindPhoneExtensionByEmployeeIDDataSet FindPhoneExtensionByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindPhoneExtensionByEmployeeIDDataSet = new FindPhoneExtensionByEmployeeIDDataSet();
                aFindPhoneExtensionByEmployeeIDTableAdapter = new FindPhoneExtensionByEmployeeIDDataSetTableAdapters.FindPhoneExtensionByEmployeeIDTableAdapter();
                aFindPhoneExtensionByEmployeeIDTableAdapter.Fill(aFindPhoneExtensionByEmployeeIDDataSet.FindPhoneExtensionByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Find Phone Extension By Employee ID " + Ex.Message);
            }

            return aFindPhoneExtensionByEmployeeIDDataSet;
        }
        public FindSortedExtensionsByLastNameDataSet FindSortedExtensionsByLastName()
        {
            try
            {
                aFindSortedExtensionsByLastNameDataSet = new FindSortedExtensionsByLastNameDataSet();
                aFindSortedExtensionsByLastNameTableAdapter = new FindSortedExtensionsByLastNameDataSetTableAdapters.FindSortedExtensionsByLastNameTableAdapter();
                aFindSortedExtensionsByLastNameTableAdapter.Fill(aFindSortedExtensionsByLastNameDataSet.FindSortedExtensionsByLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Find Sorted Extensions By Last Name " + Ex.Message);
            }

            return aFindSortedExtensionsByLastNameDataSet;
        }

        public FindSortedPhoneListByExtensionDataSet FindSortedPhoneListByExtension()
        {
            try
            {
                aFindSortedPhoneListByExtensionDataSet = new FindSortedPhoneListByExtensionDataSet();
                aFindSortedPhoneListByExtensionTableAdapter = new FindSortedPhoneListByExtensionDataSetTableAdapters.FindSortedPhoneListByExtensionTableAdapter();
                aFindSortedPhoneListByExtensionTableAdapter.Fill(aFindSortedPhoneListByExtensionDataSet.FindSortedPhoneListByExtension);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Find Sorted Phone List By Extension " + Ex.Message);
            }

            return aFindSortedPhoneListByExtensionDataSet;
        }
        public FindPhoneByExtensionDataSet FindPhoneByExtension(int intExtension)
        {
            try
            {
                aFindPhoneByExtensionDataSet = new FindPhoneByExtensionDataSet();
                aFindPhoneByExtensionTableAdapter = new FindPhoneByExtensionDataSetTableAdapters.FindPhoneByExtensionTableAdapter();
                aFindPhoneByExtensionTableAdapter.Fill(aFindPhoneByExtensionDataSet.FindPhoneByExtension, intExtension);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phones Class // Find Phone By Extension " + Ex.Message);
            }

            return aFindPhoneByExtensionDataSet;
        }
        public bool UpdatePhoneExtension(int intTransactionID, int intExtension)
        {
            bool blnFatalError = false;

            try
            {
                aUpdatePhoneExtensionTableAdapter = new UpdatePhoneExtensionEntryTableAdapters.QueriesTableAdapter();
                aUpdatePhoneExtensionTableAdapter.UpdatePhoneExtension(intTransactionID, intExtension);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Update Phone Extension " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool UpdateEmployeePhone(int intTransactionID, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeePhoneTableAdapter = new UpdateEmployeePhoneEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeePhoneTableAdapter.UpdateEmployeePhone(intTransactionID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Update Employee Phone " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertPhone(int intExtension, string strDirectNumber, int intEmployeeID, int intWarehouseID, string strMACAddress)
        {
            bool blnFatalError = false;

            try
            {
                aInsertPhoneTableAdapter = new InsertPhoneEntryTableAdapters.QueriesTableAdapter();
                aInsertPhoneTableAdapter.InsertPhone(intExtension, strDirectNumber, intEmployeeID, intWarehouseID, strMACAddress);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phone Class // Insert Phone " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public PhoneListDataSet GetPhoneListInfo()
        {
            try
            {
                aPhoneListDataSet = new PhoneListDataSet();
                aPhoneListTableAdapter = new PhoneListDataSetTableAdapters.phonelistTableAdapter();
                aPhoneListTableAdapter.Fill(aPhoneListDataSet.phonelist);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phones Class // Get Phone List Info " + Ex.Message);
            }

            return aPhoneListDataSet;
        }
        public void UpdatePhoneListDB(PhoneListDataSet aPhoneListDataSet)
        {
            try
            {
                aPhoneListTableAdapter = new PhoneListDataSetTableAdapters.phonelistTableAdapter();
                aPhoneListTableAdapter.Update(aPhoneListDataSet.phonelist);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Phones Class // Update Phone List DB " + Ex.Message);
            }
        }
    }
}
