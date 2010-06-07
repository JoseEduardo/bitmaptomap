Public Module Constants
    Public Const NodeStart As Byte = &HFE
    Public Const NodeEnd As Byte = &HFF
    Public Const Escape As Byte = &HFD

    Public Enum NodeType As Byte
        RootV1 = 0
        ' 1 does not work
        MapData = 2
        ItemDef = 3
        TileArea = 4
        Tile = 5
        Item = 6
        TileSquare = 7
        TileRef = 8
        Spawns = 9
        SpawnArea = 10
        Monster = 11
        Towns = 12
        Town = 13
        HouseTile = 14
        Waypoints = 15
        Waypoint = 16
    End Enum

    Public Enum AttrType As Byte
        None = 0
        Description = 1
        ExtFile = 2
        TileFlags = 3
        ActionID = 4
        UniqueID = 5
        Text = 6
        Desc = 7
        TeleDest = 8
        Item = 9
        DepotID = 10
        ExpSpawnFile = 11
        RuneCharges = 12
        ExtHouseFile = 13
        HouseDoorID = 14
        Count = 15
        Duration = 16
        DecayingState = 17
        WrittenDate = 18
        WrittenBy = 19
        SleeperGUID = 20
        SleepStart = 21
        Charges = 22
    End Enum
End Module
