﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrupperumServer.CtrlLayer;
using TestData;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        TestContainer tc = new TestContainer();
        [TestMethod]
        public void DoesTestContainerExist()
        {
            Assert.IsNotNull(tc);
        }

        [TestMethod]
        public void IsClassRoomsCreated()
        {
            Assert.AreEqual<int>(tc.classRooms.Count, 50);
        }

        [TestMethod]
        public void IsGroupsCreated()
        {
            Assert.AreEqual<int>(tc.groups.Count, 100);
        }

        [TestMethod]
        public void IsRequestsCreated()
        {
            Assert.AreEqual<int>(tc.requests.Count, 100);
        }

        //var classList = Unittest.Testmodel.GetClassRoomList();
        // var grouproomList = Unittest.TestmodelGetGroupRoomList();
        // ControlLayer.GrooupRoomControler ctlr = new ControlLayer.GrooupRoomControler(new TestContainer());

        // ctlr.Add()..
    }
}
