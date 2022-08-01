
List<object> objectList = new List<object>() 
{
    7, 28, -1, true, "chair"
};

var sum = 0;
List<int> intList = new List<int>();
foreach( object item in objectList )
{
    if( item is int )
    {
        // intList.Add( item );
        sum += (int)item;
    };
};
Console.WriteLine( sum );
