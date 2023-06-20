using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.BodyComponents.Containers;
using html_creator_library.HeadComponents;
using html_creator_library.Css;
using html_creator_library.Css.StyleComponents;

namespace library_test
{
    internal class IndividualElements
    {
        public string GetBlockOfButtons()
        {
            var div = new Div(
                new Button(new Text("Кнопка 1")),
                new Button(new Text("Кнопка 2", TextType.B))
            );

            return div.GetStringHtml();
        }
    }
}
