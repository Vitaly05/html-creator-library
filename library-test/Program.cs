using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.BodyComponents.Containers;
using html_creator_library.HeadComponents;
using html_creator_library.Css;
using html_creator_library.Css.StyleComponents;
using library_test;

IndividualElements individualElements = new();
Console.WriteLine(individualElements.GetBlockOfButtons());



const string siteFolder = "../../../../site/";


Style delTextStyle = new Style(
    new Background().SetColor(Color.DarkOliveGreen),
    new Border().Width("5px", "10px")
        .Radius("5px", "0")
        .Color(Color.Yellow)
        .Style(BorderStyle.Solid, BorderStyle.Double),
    new Shadow(ShadowType.Box, "10px", "10px", "10px", Color.Purple),
    new TextColor(Color.Orange),
    new Indent(IndentType.Margin, "10px"),
    new Opacity("50%"),
    new Position(PositionType.Fixed).Top("150px").Left("500px")
).Class("delText");

Style secondStyle = new Style(
    new Background().SetColor(Color.Blue),
    new Indent(IndentType.Padding, "10px", "5px"),
    new Transition(DefaultProperty.Background).SetDuration("1s").SetTimingFunction(TimingFunction.EaseInOut).SetDelay("0.1s")
).Selector("button");

Style secondHoverStyle = new Style(
    new Background().SetColor(Color.Red),
    new Indent(IndentType.Padding, "10px", "5px")
).Selector("button").Hover();

Style secondCustomStyle = new Style(
    new Background().SetColor(Color.Green),
    new Indent(IndentType.Padding, "10px", "5px")
).Selector("button").PseudoClass(":active");

Style buttonWithTextStyle = new Style(
    new Indent(IndentType.Margin, "20px"),
    new Size("100px", null),
    new BoxSizing(BoxSizingType.BorderBox)
).Class("buttonWithText");

Style divWithDisplayStyle = new Style(
    new Display(DisplayType.Flex, JustifyContent.SpaceAround),
    new Size("100%", "200px"),
    new MaxSize("1200px", null),
    new MinSize("700px", null),
    new Font().Family(FontFamily.Courier).Size("20px").Style(FontStyle.Normal).Variant("small-caps").Weight("bold").LineHeight("2")
).Id("divWithDisplay");

Style divvStyle = new Style(
    new Size(null, "50px")
).Id("divv");

Style topFTextStyle = new Style(
    new VerticalAlign(VerticalAlignType.Super)
).Id("topFText");

Style mainContainerStyle = new Style(
    new Background().SetImage("img/2.jpg").SetAttachment(AttachmentType.Local),
    new Size(null, "100px"),
    new Overflow().Y(OverflowType.Scroll)
).Id("mainContainer");

Style sectionContainerStyle = new Style(
    new Background().SetGradient(new Gradient(GradientType.LinearGradient, "90deg", Color.Gray, Color.White))
).Id("sectionContainer");


Header testHeader = new Header(
    new Div(
        attribute: new HtmlAttribute().Custom("style=\"background: grey;\""),
        new Text(
            text: "Hello",
            textType: TextType.Del,
            attribute: new HtmlAttribute().Class("delText")
                .Hidden(false)
                .Data(name: "myData", value: "myValue")
                .Title("HELLO")
        ),
        new LineBreak(),
        new LineBreak(),
        new Button(
            attribute: new HtmlAttribute().Class("buttonWithText"),
            components:
                new Text(
                    text: "button",
                    textType: TextType.B,
                    attribute: new HtmlAttribute().Id("bText")
                )
        )
    )
);

Main testMain = new Main(
    attribute: new HtmlAttribute().Id("mainContainer"),
    new Div(
        attribute: new HtmlAttribute(),
        new Text(
            text: "Hello",
            textType: TextType.Del,
            attribute: new HtmlAttribute().Class("delText")
                .Hidden(false)
                .Data(name: "myData", value: "myValue")
                .Title("HELLO")
        ),
        new LineBreak(),
        new LineBreak(),
        new Button(
            attribute: new HtmlAttribute().Class("buttonWithText"),
            components:
                new Text(
                    text: "button",
                    textType: TextType.B,
                    attribute: new HtmlAttribute().Id("bText")
                )
        )
    ),
    new Menu(
        new ListItem(new Text("1", TextType.Font, new HtmlAttribute().Color(Color.White))),
        new ListItem(new Text("2", TextType.Font, new HtmlAttribute().Color(Color.White))),
        new ListItem(new Text("3", TextType.Font, new HtmlAttribute().Color(Color.White)))
    ),
    new Image($"img/1.jpg", "cat", new HtmlAttribute().Width("100px"))
);

Article testArticle = new Article(
    new Text(
        text: "Without attribute"
    )
);

Section testSection = new Section(
    attribute: new HtmlAttribute().Id("sectionContainer"),
    new Span("ffff", new HtmlAttribute().Color("red")),
    new LineBreak(),
    new TextArea("Inner text"),
    new Input(InputType.Color)
);

Footer testFooter = new Footer(
    new Text("Footer", TextType.B)
);

Body testBody = new();
testBody.SetContext(
    testHeader,
    testMain,

    new Line(new HtmlAttribute().Color("red").Size("20px").Width("90%")),
    
    testArticle,
    testSection,

    new UnorderedList(
        new ListItem(
            new Text("First")
        ),
        new ListItem(
            new Button(
                new Text("Second")
            )
        )
    ),

    new Div(
        attribute: new HtmlAttribute().Id("divWithDisplay"),
        new Text("FFF✌️", TextType.U),
        new Text("ggg", TextType.I),
        new Text("HHH☻", TextType.B),
        new Div(
            new Text("10"),
            new Text("2", TextType.Sup)
        )
    ),
    new LineBreak(),
    new Div(
        new HtmlAttribute().Id("divv"),
        new Text("fff", TextType.B),
        new Text("fff", TextType.B, new HtmlAttribute().Id("topFText"))
    ),

    testFooter
);

Head testHead = new();
testHead.SetContext(
    new Title("Test"),
    new Meta("utf-8"),
    new Meta().HttpEquiv("refresh", "50")
);

HTML test = new(
    body: testBody,
    head: testHead
);
test.SetStyles(
    delTextStyle,
    secondStyle,
    secondHoverStyle,
    secondCustomStyle,
    buttonWithTextStyle,
    divWithDisplayStyle,
    divvStyle,
    topFTextStyle,
    mainContainerStyle,
    sectionContainerStyle
);
test.SaveFile(siteFolder, htmlName: "start.html", cssName: "myStyle.css");