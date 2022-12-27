using html_creator_library;
using html_creator_library.Components;

Body testBody = new();
testBody.SetContext(
    new Button("button 1"),
    new Button("button 2")
);
HTML test = new(
    body: testBody
);
test.SaveFile();