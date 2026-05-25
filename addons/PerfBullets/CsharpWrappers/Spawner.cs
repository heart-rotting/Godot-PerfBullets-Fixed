using Godot;

/// <summary>
/// C# Wrapper around Spawner class
/// </summary>
public partial class Spawner : MultiMeshInstance2D
{

    private readonly GodotObject _node;
 
    public Spawner(GodotObject node)
    {
        if (node == null)
            throw new System.ArgumentNullException(nameof(node),
                "Node is null — check your GetNode path.");
 
        if (!ClassDB.IsParentClass(node.GetClass(), "MultiMeshInstance2D"))
            GD.PushWarning($"Spawner wrapper: expected a MultiMeshInstance2D, got {node.GetClass()}");
 
        _node = node;
    }


    #region Enums

    public enum Mode
    {
        Process = 0,
        Physics = 1
    }

    public enum StartMode
    {
        OnStart = 0,
        PatternManager = 1,
        Manual = 2
    }

    #endregion

    #region Properites

    public StartMode SpawnerStartMode
    {
        get => (StartMode)(int)_node.Get("start_mode");
        set => _node.Set("start_mode", (int)value);
    }
 
    public Godot.Collections.Array Bullets
    {
        get => (Godot.Collections.Array)_node.Get("bullets");
        set => _node.Set("bullets", value);
    }
 
    public int Id
    {
        get => (int)_node.Get("id");
        set => _node.Set("id", value);
    }
 
    public bool MoveWithParent
    {
        get => (bool)_node.Get("move_with_parent");
        set => _node.Set("move_with_parent", value);
    }
 
    public Node2D TrackedNode
    {
        get => _node.Get("tracked_node").As<Node2D>();
        set => _node.Set("tracked_node", value);
    }
 
    /// <summary>Write-only — no get_bounding_box exists in C++.</summary>
    public Rect2 BoundingBox
    {
        set => _node.Call("set_bounding_box", value);
    }
 
    public bool Start
    {
        get => (bool)_node.Get("start");
        set => _node.Set("start", value);
    }
 
    public int PoolCount
    {
        get => (int)_node.Get("pool_count");
        set => _node.Set("pool_count", value);
    }
 
    public float TextureRotation
    {
        get => (float)_node.Get("texture_rotation");
        set => _node.Set("texture_rotation", value);
    }
 
    public float FireRate
    {
        get => (float)_node.Get("fire_rate");
        set => _node.Set("fire_rate", value);
    }
 
    public float FireRadiusDegrees
    {
        get => (float)_node.Get("fire_radius_degrees");
        set => _node.Set("fire_radius_degrees", value);
    }
 
    public float StartRotation
    {
        get => (float)_node.Get("start_rotation");
        set => _node.Set("start_rotation", value);
    }
 
    public int NumberOfRadii
    {
        get => (int)_node.Get("number_of_radii");
        set => _node.Set("number_of_radii", value);
    }
 
    public float DegreesBetweenRadii
    {
        get => (float)_node.Get("degrees_between_radii");
        set => _node.Set("degrees_between_radii", value);
    }
 
    public int BulletsPerRadius
    {
        get => (int)_node.Get("bullets_per_radius");
        set => _node.Set("bullets_per_radius", value);
    }
 
    public float SpinRate
    {
        get => (float)_node.Get("spin_rate");
        set => _node.Set("spin_rate", value);
    }
 
    /// <summary>
    /// The BulletType resource. Typed as Resource since BulletType is
    /// also a GDExtension class without a C# wrapper.
    /// </summary>
    public Resource BulletType
    {
        get => _node.Get("bullet_type").As<Resource>();
        set => _node.Set("bullet_type", value);
    }
 
    public int NumberOfShots
    {
        get => (int)_node.Get("number_of_shots");
        set => _node.Set("number_of_shots", value);
    }
 
    /// <summary>Maps to set_random / get_random in C++.</summary>
    public bool RandomFire
    {
        get => (bool)_node.Get("random");
        set => _node.Set("random", value);
    }
 
    public float RandomRadius
    {
        get => (float)_node.Get("random_radius");
        set => _node.Set("random_radius", value);
    }
 
    public float MaxSpin
    {
        get => (float)_node.Get("max_spin");
        set => _node.Set("max_spin", value);
    }
 
    public float MinSpin
    {
        get => (float)_node.Get("min_spin");
        set => _node.Set("min_spin", value);
    }
 
    public bool RestartAtSpin
    {
        get => (bool)_node.Get("restart_at_spin");
        set => _node.Set("restart_at_spin", value);
    }
 
    public float SpinAcceleration
    {
        get => (float)_node.Get("spin_acceleration");
        set => _node.Set("spin_acceleration", value);
    }
 
    public Mode SpawnerMode
    {
        get => (Mode)(int)_node.Get("spawner_mode");
        set => _node.Set("spawner_mode", (int)value);
    }
 
    public bool Homing
    {
        get => (bool)_node.Get("homing");
        set => _node.Set("homing", value);
    }
 
    public float HomingWeight
    {
        get => (float)_node.Get("homing_weight");
        set => _node.Set("homing_weight", value);
    }
 
    public bool StartTowardPlayer
    {
        get => (bool)_node.Get("start_toward_player");
        set => _node.Set("start_toward_player", value);
    }
 
    public bool StaysTowardPlayer
    {
        get => (bool)_node.Get("stays_toward_player");
        set => _node.Set("stays_toward_player", value);
    }
 
    public float OffsetTowardPlayer
    {
        get => (float)_node.Get("offset_toward_player");
        set => _node.Set("offset_toward_player", value);
    }
 
    public float Gravity
    {
        get => (float)_node.Get("gravity");
        set => _node.Set("gravity", value);
    }
 
    public int RowsInAtlas
    {
        get => (int)_node.Get("rows_in_atlas");
        set => _node.Set("rows_in_atlas", value);
    }
 
    public int ColumnsInAtlas
    {
        get => (int)_node.Get("columns_in_atlas");
        set => _node.Set("columns_in_atlas", value);
    }
 
    public bool ReturnBulletsToPoolAutomatically
    {
        get => (bool)_node.Get("return_bullets_to_pool_automatically");
        set => _node.Set("return_bullets_to_pool_automatically", value);
    }
 
    public bool ManualStart
    {
        get => (bool)_node.Get("manual_start");
        set => _node.Set("manual_start", value);
    }


    #endregion
 
    #region Methods
 
    /// <summary>Starts the spawner with a given pattern ID.</summary>
    public void StartNode(int id) => _node.Call("start_node", id);
 
    /// <summary>Manually spawns a bullet in the given direction.</summary>
    public void SpawnBulletSelf(Vector2 direction) => _node.Call("spawn_bullet_self", direction);
 
    /// <summary>Clears and returns all active bullets to the pool.</summary>
    public void ClearAll() => _node.Call("clear_all");
 
    /// <summary>Returns a specific bullet to the pool by index.</summary>
    public void FreeBulletToPool(int idx) => _node.Call("free_bullet_to_pool", idx);
 
    /// <summary>Returns the next available pool index.</summary>
    public int GetNextIdx() => (int)_node.Call("get_next_idx");
 
    /// <summary>Returns all currently active bullet objects.</summary>
    public Godot.Collections.Array GetActiveBullets()
        => (Godot.Collections.Array)_node.Call("get_active_bullets");
 
    /// <summary>
    /// Returns a BulProps resource by pool index.
    /// Typed as Resource since BulProps is also a GDExtension type.
    /// </summary>
    public Resource GetBulletFromIndex(int idx)
        => _node.Call("get_bullet_from_index", idx).As<Resource>();


    #endregion
}