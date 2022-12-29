using html_creator_library;
using html_creator_library.BodyComponents;
using html_creator_library.HeadComponents;

Body testBody = new();
testBody.SetContext(
    new Text(
        text: "Hello",
        textType: TextType.Del
    ),
    new Button(
        new Text(
            text: "button",
            textType: TextType.B
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
test.SaveFile();