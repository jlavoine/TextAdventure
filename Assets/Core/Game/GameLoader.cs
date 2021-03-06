﻿using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;

public class GameLoader : MonoBehaviour {
    public TextAsset Maps;

    private void Awake() {
        string json = Maps.text;
        List<MapData> maps = JsonConvert.DeserializeObject<List<MapData>>(json, new Newtonsoft.Json.Converters.StringEnumConverter());
        foreach(MapData map in maps) {
            Debug.Log(map);
        }
        /*List<MapData> maps = new List<MapData>();
        maps.Add(CreateMap());

        Debug.LogError(JsonConvert.SerializeObject(maps, new Newtonsoft.Json.Converters.StringEnumConverter()));*/
    }

    private MapData CreateMap() {
        List<RoomData> rooms = new List<RoomData>();
        for (int i = 0; i < 4; ++i) {
            rooms.Add(CreateRoom());
        }

        return new MapData() { Rooms = rooms, Id = "id" };
    }

    private RoomData CreateRoom() {
        return new RoomData() { Description = "blahblah", Title = "title", Id = "id", DirectionalExits = new List<DirectionalExit>() { new DirectionalExit() { Direction = Direction.North, TargetMapId = "a", TargetRoomId = "b" } } };
    }
}
