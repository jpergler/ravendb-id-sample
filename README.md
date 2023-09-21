# Raven ID Sample

It shows that for single-word document names the convention for creating prefix in document ID is different for `RavenDB.Client` NuGet package library and when prefilling the prefix in Studio.

For `Item` the default convention in C# is `items/1-A` while in Studio when cloning it prefillx `Items/` which makes a discrepancy.

For `MultiWordItem` the default convention in C# `MultiWordItems/1-A` matches the Studio `MultiWordItems`.

While not a big deal it made me a little headache in development.
