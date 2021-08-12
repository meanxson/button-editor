# button-editor
Button Editor For Unity Inspector


```
public class Example : MonoBehaviour
{
   [EditorButton("Name Of Button")]
   public void Foo()
   {
      //Do Something...
   }
}
```

```

public class Example : MonoBehaviour
{
   [EditorButton()] // Name will taken from the name of the method
   public void Foo()
   {
      //Do Something...
   }
}

```
