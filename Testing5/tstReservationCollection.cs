﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstReservationCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsReservationCollection AllReservation = new clsReservationCollection();
            //test to see that is exists
            Assert.IsNotNull(AllReservation);
        }
        [TestMethod]
        public void ReservationCollectionListOK()
        {
            //create an instance of the class we want to create
            clsReservationCollection AllReservation = new clsReservationCollection();
            //create some test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsReservation> TestList = new List<clsReservation>();
            //Add an item to the list 
            //create the item of test data
            clsReservation TestItem = new clsReservation();
            //set its properties
            TestItem.Age = true;
            TestItem.ReservationId = 2;
            TestItem.CustomerId = 1;
            TestItem.DateAndTime = DateTime.Now;
            TestItem.Name = "efaz";
            TestItem.Phone = "0773828447735";
            TestItem.TableNumber = 12;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllReservation.ReservationList = TestList;
            //tset to see that the two vcalues are the same
            Assert.AreEqual(AllReservation.ReservationList, TestList);
        }
        [TestMethod]
        public void ThisReservationPropertyOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            clsReservation TestReservation = new clsReservation();
            TestReservation.Age = true;
            TestReservation.ReservationId = 2;
            TestReservation.CustomerId = 1;
            TestReservation.DateAndTime = DateTime.Now;
            TestReservation.Name = "efaz";
            TestReservation.Phone = "0773828447735";
            TestReservation.TableNumber = 12;
            AllReservation.ThisReservation = TestReservation;
            Assert.AreEqual(AllReservation.ThisReservation, TestReservation);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            List<clsReservation> TestList = new List<clsReservation>();
            clsReservation TestItem = new clsReservation();
            TestItem.Age = true;
            TestItem.ReservationId = 2;
            TestItem.CustomerId = 1;
            TestItem.DateAndTime = DateTime.Now;
            TestItem.Name = "efaz";
            TestItem.Phone = "0773828447735";
            TestItem.TableNumber = 12;
            TestList.Add(TestItem);
            AllReservation.ReservationList = TestList;
            Assert.AreEqual(AllReservation.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            clsReservation TestItem = new clsReservation();
            Int32 PrimaryKey = 0;
            TestItem.Age = true;
            TestItem.ReservationId = 2;
            TestItem.CustomerId = 1;
            TestItem.DateAndTime = DateTime.Now;
            TestItem.Name = "efaz";
            TestItem.Phone = "0773828447735";
            TestItem.TableNumber = 12;
            AllReservation.ThisReservation = TestItem;
            PrimaryKey = AllReservation.Add();
            TestItem.ReservationId = PrimaryKey;
            AllReservation.ThisReservation.Find(PrimaryKey);
            Assert.AreEqual(AllReservation.ThisReservation, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            clsReservation TestItem = new clsReservation();
            Int32 PrimaryKey = 0;
            TestItem.Age = true;
            TestItem.ReservationId = 2;
            TestItem.CustomerId = 1;
            TestItem.DateAndTime = DateTime.Now;
            TestItem.Name = "efaz";
            TestItem.Phone = "0773828447735";
            TestItem.TableNumber = 12;
            AllReservation.ThisReservation = TestItem;
            PrimaryKey = AllReservation.Add();
            TestItem.ReservationId = PrimaryKey;
            TestItem.Age = false;
            TestItem.CustomerId = 1;
            TestItem.DateAndTime = DateTime.Now;
            TestItem.Name = "heda";
            TestItem.Phone = "0773828449935";
            TestItem.TableNumber = 13;
            AllReservation.ThisReservation = TestItem;
            AllReservation.Update();
            AllReservation.ThisReservation.Find(PrimaryKey);
            Assert.AreEqual(AllReservation.ThisReservation, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            clsReservation TestItem = new clsReservation();
            Int32 PrimaryKey = 0;
            TestItem.Age = true;
            TestItem.ReservationId = 2;
            TestItem.CustomerId = 1;
            TestItem.DateAndTime = DateTime.Now;
            TestItem.Name = "efaz";
            TestItem.Phone = "0773828447735";
            TestItem.TableNumber = 12;
            AllReservation.ThisReservation = TestItem;
            PrimaryKey = AllReservation.Add();
            TestItem.ReservationId = PrimaryKey;
            AllReservation.ThisReservation.Find(PrimaryKey);
            AllReservation.Delete();
            Boolean Found = AllReservation.ThisReservation.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsReservationCollection AllReservation = new clsReservationCollection();
            clsReservationCollection FilterReservation = new clsReservationCollection();
            FilterReservation.ReportByName("");
            Assert.AreEqual(AllReservation.Count, FilterReservation.Count);
        }
        [TestMethod]
        public void ReportByNameNoneMethodOK()
        {
            clsReservationCollection FilterReservation = new clsReservationCollection();
            FilterReservation.ReportByName("xxx xxx");
            Assert.AreEqual(0, FilterReservation.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsReservationCollection FilterReservation = new clsReservationCollection();
            Boolean OK = true;
            FilterReservation.ReportByName("yyy yyy");
            if (FilterReservation.Count == 2)
            {
                if (FilterReservation.ReservationList[0].ReservationId != 64)
                {
                    OK = false;
                }
                if (FilterReservation.ReservationList[1].ReservationId != 65) 
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
