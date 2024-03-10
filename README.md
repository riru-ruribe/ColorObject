# ColorObject

## overview
treat a struct 'UnityEngine.Color' as if it were a 'UnityEngine.Object'.

## UPM
<pre>https://github.com/riru-ruribe/ColorObject.git?path=Assets/ColorObject</pre>

## detail
treat text file with the extension **clo** as 'ScriptableObject'.  
it may be possible to suppress compilation when you want to change any colors.

the supported formats are as following
- byte:r,g,b,a
- float:r,g,b,a

instance is created with 'UnityEngine.Color32' for byte and 'UnityEngine.Color' for float.
