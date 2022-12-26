using html_creator_library;
using html_creator_library.Components;

HTML test = new();
test.SetContext(
    new Button("button 1"),
    new Button("button 2")
);
test.PrintComponentsInfo();