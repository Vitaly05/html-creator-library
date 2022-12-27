using html_creator_library;
using html_creator_library.Components;

Body testBody = new();
testBody.SetContext(
    new Text(
        text: "Hello",
        textType: TextType.H1
    ),
    new Button(
        new Text(
            text: "button",
            textType: TextType.Default
        )
    )
);
HTML test = new(
    body: testBody
);
test.SaveFile();