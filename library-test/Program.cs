﻿using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.HeadComponents;

Body testBody = new();
testBody.SetContext(
    new Text(
        text: "Hello",
        textType: TextType.Del,
        attribute: new HtmlAttribute().Class("delText")
            .Hidden(false)
            .Data(name: "myData", value: "myValue")
            .Title("HELLO")
    ),
    new LineBreak(),
    new Button(
        attribute: new HtmlAttribute().Class("buttonWithText"),
        components:
            new Text(
                text: "button",
                textType: TextType.B,
                attribute: new HtmlAttribute().Id("bText")
            )
    ),
    new Line(new HtmlAttribute().Color("red").Size("20px").Width("90%")),
    new Text(
        text: "Without attribute"
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
test.SaveFile();