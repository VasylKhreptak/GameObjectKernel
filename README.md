Issue. When using GameObjectContext you sometimes need to get an event when the root object has been disabled on enabled. With this tool you can be notified about these events via interfaces. 
You just need to add the GameObjectKernel component to your GameObjectContext and you can implement IEnableEventHandler and IDisableEventHandler.
