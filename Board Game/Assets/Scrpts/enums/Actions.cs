using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Actions{

	NULL = 0,
    START = 1,

    //Space-craft
    CREATE_SOLDIER = 101,
    CREATE_VILLAGER = 102,
    CREATE_TECHNICIAN = 103,

    //Soldier
    EXPLORATION = 1001,
    CONFLICT = 1002,

    //villagers
    PRODUCTION_FOOD = 2001,

    //technician
    EVOLUTION = 3001
    
}
