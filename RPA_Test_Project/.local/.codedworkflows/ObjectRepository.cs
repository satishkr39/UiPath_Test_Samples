using UiPath.CodedWorkflows.DescriptorIntegration;

namespace RPA_Test_Project.ObjectRepository
{
    public static class Descriptors
    {
        public static class AccuWeather
        {
            static string _reference = "uXCo1HYtOEec5ciefe-HLw/QmBXqFq1mEKz3d5w9vAokQ";
            public static _Implementation._AccuWeather.__Edge__Local__National____Global_Daily_Weather Edge__Local__National____Global_Daily_Weather { get; private set; } = new _Implementation._AccuWeather.__Edge__Local__National____Global_Daily_Weather();
        }

        public static class __Edge__UiBank_Loan_Apply
        {
            static string _reference = "uXCo1HYtOEec5ciefe-HLw/jtcbwE9cA0yYj4nw8zbT7Q";
            public static _Implementation.___Edge__UiBank_Loan_Apply.__Edge__UiBank_Loan_Apply Edge__UiBank_Loan_Apply { get; private set; } = new _Implementation.___Edge__UiBank_Loan_Apply.__Edge__UiBank_Loan_Apply();
        }
    }
}

namespace RPA_Test_Project._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace _AccuWeather._Edge__Local__National____Global_Daily_Weather
    {
        public class __ClickMainLogo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ClickMainLogo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "uXCo1HYtOEec5ciefe-HLw/fnxb5lA7REOYgF05ywTKQw",
                    DisplayName = "ClickMainLogo",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _AccuWeather
    {
        public class __Edge__Local__National____Global_Daily_Weather : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge__Local__National____Global_Daily_Weather()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "uXCo1HYtOEec5ciefe-HLw/PNKuo4B5XUOxUM6cLLam2w",
                    DisplayName = "Edge: Local, National, & Global Daily Weather",
                    Screen = this
                };
                ClickMainLogo = new _Implementation._AccuWeather._Edge__Local__National____Global_Daily_Weather.__ClickMainLogo(this, null);
            }

            public _Implementation._AccuWeather._Edge__Local__National____Global_Daily_Weather.__ClickMainLogo ClickMainLogo { get; private set; }
        }
    }

    namespace ___Edge__UiBank_Loan_Apply._Edge__UiBank_Loan_Apply
    {
        public class __Loan_Amount_Requested : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Amount_Requested(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "uXCo1HYtOEec5ciefe-HLw/PJIiln3uu0-vg-RTa8qXJg",
                    DisplayName = "Loan Amount Requested",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge__UiBank_Loan_Apply
    {
        public class __Edge__UiBank_Loan_Apply : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge__UiBank_Loan_Apply()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "uXCo1HYtOEec5ciefe-HLw/hk5Ooz0hWUqB4wvmI9B_OA",
                    DisplayName = "Edge: UiBank-Loan Apply",
                    Screen = this
                };
                Loan_Amount_Requested = new _Implementation.___Edge__UiBank_Loan_Apply._Edge__UiBank_Loan_Apply.__Loan_Amount_Requested(this, null);
            }

            public _Implementation.___Edge__UiBank_Loan_Apply._Edge__UiBank_Loan_Apply.__Loan_Amount_Requested Loan_Amount_Requested { get; private set; }
        }
    }
}