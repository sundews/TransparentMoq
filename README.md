# TransparentMoq

With inspiration taken from mocking frameworks like NSubstitute, FakeItEasy and JustMock this package adds some of the syntactic advantages of these frameworks to Moq.

TransparentMoq allows to use Moq without having to store mocks in Mock<T> variables, instead a T variable can be used. This also removes the need to pass mocks with ".Object" everywhere as they can be passed directly.

The library provides extension methods for most (if not all) of Moq's methods, so they can be called directly on the T variable.
Examples:
Instead of
```
private Mock<IFileSystem> fileSystem = new Mock<IFileSystem>();
```
write
```
private IFileSystem fileSystem = New.Mock<IFileSystem>();
```
Instead of
```
MethodThatTakesFileSystem(fileSystem.Object);
```
write
```
MethodThatTakesFileSystem(fileSystem);
```

To arrange a mock everything remains the same:
```
fileSystem.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);
```