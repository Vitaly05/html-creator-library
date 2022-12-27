using html_creator_library;
using html_creator_library.Components;

Body testBody = new();
testBody.SetContext(
    new Button(
        new Button()
    ),
    new Button()
);
HTML test = new(
    body: testBody
);
test.SaveFile();