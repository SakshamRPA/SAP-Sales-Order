using System;
using System.Collections.Generic;
using System.Data;
using SAPSalesOrderAutomation.ObjectRepository;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace SAPSalesOrderAutomation
{
    public class CodedTestCase : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            // Arrange
            Log("Test run started for CodedTestCase.");
            
            

            // Act
            var sapLogonScreen = uiAutomation.Open(Descriptors.SAP_Logon_770_app.SAP_Logon_770);          

        using var screen1 = uiAutomation.Open(
                Descriptors.SAP_Logon_770_app.SAP_Logon_770, 
                openMode: NAppOpenMode.IfNotOpen, 
                interactionMode: NInteractionMode.HardwareEvents
            );
            screen1.Click(
                Descriptors.SAP_Logon_770_app.SAP_Logon_770.S3X, 
                Options.Click(NClickType.Single, NMouseButton.Left).With(interactionMode: NChildInteractionMode.SameAsCard)
            );
            screen1.Click(
                Descriptors.SAP_Logon_770_app.SAP_Logon_770.S3X, 
                Options.Click(NClickType.Single, NMouseButton.Right).With(interactionMode: NChildInteractionMode.SameAsCard)
            );
            screen1.Click(
                Descriptors.SAP_Logon_770_app.SAP_Logon_770.Log_On_Enter, 
                Options.Click(NClickType.Single, NMouseButton.Left).With(interactionMode: NChildInteractionMode.SameAsCard)
            );
            

            // Open the SAP login screen
            var sapLoginScreen = uiAutomation.Open(Descriptors.SAP_Logon_770_app.SAP);

            // Type into the User field
            sapLoginScreen.TypeInto(Descriptors.SAP_Logon_770_app.SAP.User, "thirugnanas");

            // Type into the Password field
            sapLoginScreen.TypeInto(Descriptors.SAP_Logon_770_app.SAP.Password, "Yash@123456789");

            // Click the Continue (Enter) button
            sapLoginScreen.Click(Descriptors.SAP_Logon_770_app.SAP.Button_Enter);


using var screen = uiAutomation.Open(
    Descriptors.SAP_Logon_770_app.SAP_Easy_Access, 
    openMode: NAppOpenMode.IfNotOpen, 
    interactionMode: NInteractionMode.HardwareEvents
);
screen.Click(
    Descriptors.SAP_Logon_770_app.SAP_Easy_Access.UserArea_usr, 
    Options.Click(NClickType.Single, NMouseButton.Left).With(interactionMode: NChildInteractionMode.SameAsCard)
);


















            // Assert
            // To start using activities, use IntelliSense (CTRL + Space) to discover the available services, e.g. testing.VerifyExpression(...).
        }
    }
}