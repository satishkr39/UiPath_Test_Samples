using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using RPA_Test_Project;

[assembly: WorkflowRunnerServiceAttribute(typeof(RPA_Test_Project.WorkflowRunnerService))]
namespace RPA_Test_Project
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the PickAndPickBranch.xaml
        /// </summary>
        public void PickAndPickBranch()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PickAndPickBranch.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the PickAndPickBranch.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PickAndPickBranch(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PickAndPickBranch.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the TestAnyActivity.xaml
        /// </summary>
        public object TestAnyActivity(object monly)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestAnyActivity.xaml", new Dictionary<string, object> { { "monly", monly } }, default, default, default, GetAssemblyName());
            return (object)result["shiftM"];
        }

        /// <summary>
        /// Invokes the TestAnyActivity.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public object TestAnyActivity(object monly, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestAnyActivity.xaml", new Dictionary<string, object> { { "monly", monly } }, default, isolated, default, GetAssemblyName());
            return (object)result["shiftM"];
        }

        /// <summary>
        /// Invokes the SimulateEnterKey.xaml
        /// </summary>
        public void SimulateEnterKey()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SimulateEnterKey.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the SimulateEnterKey.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void SimulateEnterKey(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SimulateEnterKey.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetTransactionItem.xaml
        /// </summary>
        public void GetTransactionItem()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetTransactionItem.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetTransactionItem.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetTransactionItem(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetTransactionItem.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkbookActivity.xaml
        /// </summary>
        public void WorkbookActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkbookActivity.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkbookActivity.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WorkbookActivity(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkbookActivity.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the QueueDemo.xaml
        /// </summary>
        public void QueueDemo()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"QueueDemo.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the QueueDemo.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void QueueDemo(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"QueueDemo.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the MovieChallenge.xaml
        /// </summary>
        public void MovieChallenge()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"MovieChallenge.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the MovieChallenge.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MovieChallenge(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"MovieChallenge.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ListManipulation.xaml
        /// </summary>
        public void ListManipulation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ListManipulation.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ListManipulation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ListManipulation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ListManipulation.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the StringManipulation.xaml
        /// </summary>
        public void StringManipulation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"StringManipulation.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the StringManipulation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void StringManipulation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"StringManipulation.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the MailActivities.xaml
        /// </summary>
        public void MailActivities(string UiPathEventConnector, string UiPathEvent, string UiPathEventObjectType, string UiPathEventObjectId, string UiPathAdditionalEventData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"MailActivities.xaml", new Dictionary<string, object> { { "UiPathEventConnector", UiPathEventConnector }, { "UiPathEvent", UiPathEvent }, { "UiPathEventObjectType", UiPathEventObjectType }, { "UiPathEventObjectId", UiPathEventObjectId }, { "UiPathAdditionalEventData", UiPathAdditionalEventData } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the MailActivities.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MailActivities(string UiPathEventConnector, string UiPathEvent, string UiPathEventObjectType, string UiPathEventObjectId, string UiPathAdditionalEventData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"MailActivities.xaml", new Dictionary<string, object> { { "UiPathEventConnector", UiPathEventConnector }, { "UiPathEvent", UiPathEvent }, { "UiPathEventObjectType", UiPathEventObjectType }, { "UiPathEventObjectId", UiPathEventObjectId }, { "UiPathAdditionalEventData", UiPathAdditionalEventData } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the HoverableElemenSelection.xaml
        /// </summary>
        public void HoverableElemenSelection()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"HoverableElemenSelection.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the HoverableElemenSelection.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void HoverableElemenSelection(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"HoverableElemenSelection.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the CheckAppState.xaml
        /// </summary>
        public void CheckAppState()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CheckAppState.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the CheckAppState.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CheckAppState(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CheckAppState.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Selectors.xaml
        /// </summary>
        public void Selectors()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Selectors.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Selectors.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Selectors(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Selectors.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GoogleCloud.xaml
        /// </summary>
        public void GoogleCloud()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GoogleCloud.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GoogleCloud.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GoogleCloud(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GoogleCloud.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the FilesAndFolderOperation.xaml
        /// </summary>
        public void FilesAndFolderOperation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"FilesAndFolderOperation.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the FilesAndFolderOperation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void FilesAndFolderOperation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"FilesAndFolderOperation.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Exception.xaml
        /// </summary>
        public void Exception()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Exception.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Exception.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Exception(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Exception.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Assets.xaml
        /// </summary>
        public void Assets()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Assets.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Assets.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Assets(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Assets.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the HighlightFirstName.xaml
        /// </summary>
        public void HighlightFirstName()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"HighlightFirstName.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the HighlightFirstName.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void HighlightFirstName(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"HighlightFirstName.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Fetch_Accuweather_Month_Data.xaml
        /// </summary>
        public void Fetch_Accuweather_Month_Data()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Fetch_Accuweather_Month_Data.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Fetch_Accuweather_Month_Data.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Fetch_Accuweather_Month_Data(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Fetch_Accuweather_Month_Data.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExcelActivity.xaml
        /// </summary>
        public void ExcelActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExcelActivity.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExcelActivity.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExcelActivity(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExcelActivity.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the EmaiTesting.xaml
        /// </summary>
        public void EmaiTesting()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"EmaiTesting.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the EmaiTesting.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void EmaiTesting(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"EmaiTesting.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ArrayManipulation.xaml
        /// </summary>
        public void ArrayManipulation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ArrayManipulation.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ArrayManipulation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ArrayManipulation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ArrayManipulation.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ParallelWorkflow.xaml
        /// </summary>
        public void ParallelWorkflow()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ParallelWorkflow.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ParallelWorkflow.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ParallelWorkflow(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ParallelWorkflow.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetItemFromQueue.xaml
        /// </summary>
        public void GetItemFromQueue()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetItemFromQueue.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetItemFromQueue.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetItemFromQueue(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetItemFromQueue.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractEmailFromString.xaml
        /// </summary>
        public void ExtractEmailFromString()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractEmailFromString.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractEmailFromString.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExtractEmailFromString(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractEmailFromString.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractData.xaml
        /// </summary>
        public void ExtractData()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractData.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ExtractData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ExtractData(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ExtractData.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Dictionary.xaml
        /// </summary>
        public void Dictionary()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Dictionary.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Dictionary.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Dictionary(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Dictionary.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ACME_Employee.xaml
        /// </summary>
        public void ACME_Employee()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ACME_Employee.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ACME_Employee.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ACME_Employee(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ACME_Employee.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the VerifyExecution.xaml
        /// </summary>
        public void VerifyExecution()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"VerifyExecution.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the VerifyExecution.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void VerifyExecution(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"VerifyExecution.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the PDF_Activities.xaml
        /// </summary>
        public void PDF_Activities()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PDF_Activities.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the PDF_Activities.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PDF_Activities(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PDF_Activities.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GlobalHandler.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalHandler.xaml", new Dictionary<string, object> { { "errorInfo", errorInfo } }, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the GlobalHandler.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalHandler.xaml", new Dictionary<string, object> { { "errorInfo", errorInfo } }, default, isolated, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the CitrixAutomation.xaml
        /// </summary>
        public void CitrixAutomation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CitrixAutomation.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the CitrixAutomation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CitrixAutomation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CitrixAutomation.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AddTrxItem.xaml
        /// </summary>
        public void AddTrxItem()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AddTrxItem.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AddTrxItem.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void AddTrxItem(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AddTrxItem.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflow.cs
        /// </summary>
        public void Workflow()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflow.cs", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Workflow(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflow.cs", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}