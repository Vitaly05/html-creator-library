﻿using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.HeadComponents;
using html_creator_library.Css;
using html_creator_library.Css.StyleComponents;


Style delTextStyle = new Style(
    new Background(Color.Green),
    new Border().Width("5px", "10px")
        .Radius("5px", "0")
        .Color(Color.Blue)
        .Style(BorderStyle.Solid, BorderStyle.Double)
).Class("delText");

Style secondStyle = new Style(
    new Background(Color.Blue)
).Selector("button");

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
    secondStyle
);
test.SaveFile();