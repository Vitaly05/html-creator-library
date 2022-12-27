using html_creator_library;
using html_creator_library.Components;

HTML test = new();
Body testBody = new();
testBody.SetContext(
    new Button("button 1"),
    new Button("button 2")
);
test.SetBody(testBody);
test.SaveFile();