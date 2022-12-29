using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.HeadComponents;

Body testBody = new();
testBody.SetContext(
    new Text(
        text: "Hello",
        textType: TextType.Del,
        attribute: new HtmlAttribute().Class("delText")
    ),
    new Button(
        attribute: new HtmlAttribute().Class("buttonWithText"),
        components:
            new Text(
                text: "button",
                textType: TextType.B,
                attribute: new HtmlAttribute().Id("bText")
            )
    ),
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