using html_creator_library;
using html_creator_library.Components;

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
HTML test = new(
    body: testBody
);
test.SaveFile();