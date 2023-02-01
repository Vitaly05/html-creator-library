using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.HeadComponents;
using html_creator_library.Css;
using html_creator_library.Css.StyleComponents;


Style delTextStyle = new Style(
    new Background(Color.DarkOliveGreen),
    new Border().Width("5px", "10px")
        .Radius("5px", "0")
        .Color(Color.Yellow)
        .Style(BorderStyle.Solid, BorderStyle.Double),
    new Shadow(ShadowType.Box, "10px", "10px", "10px", Color.Purple),
    new TextColor(Color.Orange),
    new Indent(IndentType.Margin, "10px"),
    new Opacity("50%")
).Class("delText");

Style secondStyle = new Style(
    new Background(Color.Blue),
    new Indent(IndentType.Padding, "10px", "5px")
).Selector("button");

Style buttonWithTextStyle = new Style(
    new Indent(IndentType.Margin, "20px")
).Class("buttonWithText");

Style divWithDisplayStyle = new Style(
    new Display(DisplayType.Flex, JustifyContent.SpaceAround),
    new Size("100%", null),
    new MaxSize("1200px", null),
    new MinSize("700px", null),
    new Font().Family(FontFamily.Courier).Size("20px").Style(FontStyle.Normal).Variant("small-caps").Weight("bold").LineHeight("2")
).Id("divWithDisplay");

Body testBody = new();
testBody.SetContext(
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
    ),
    new Line(new HtmlAttribute().Color("red").Size("20px").Width("90%")),
    new Text(
        text: "Without attribute"
    ),
    new Span("ffff", new HtmlAttribute().Color("red")),
    new LineBreak(),
    new TextArea("Inner text"),
    new Input(InputType.Color),

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
    )
);

Head testHead = new();
testHead.SetContext(
    new Title("Test")
);

HTML test = new(
    body: testBody,
    head: testHead
);
test.SetStyles(
    delTextStyle,
    secondStyle,
    buttonWithTextStyle,
    divWithDisplayStyle
);
test.SaveFile();