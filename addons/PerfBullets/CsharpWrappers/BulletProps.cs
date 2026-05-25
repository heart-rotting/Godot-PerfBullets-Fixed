using Godot;
 
/// <summary>
/// C# Wrapper around BulletProps class
/// </summary>
public partial class BulProps : Resource
{
    private readonly GodotObject _resource;
 
    public BulProps(GodotObject resource)
    {
        if (resource == null)
            throw new System.ArgumentNullException(nameof(resource),
                "Resource is null — check your index or Spawner reference.");
 
        if (!ClassDB.IsParentClass(resource.GetClass(), "Resource"))
            GD.PushWarning($"BulProps wrapper: expected a Resource, got {resource.GetClass()}");
 
        _resource = resource;
    }
 
    #region Properties
 
    public Vector2 Position
    {
        get => (Vector2)_resource.Get("position");
        set => _resource.Set("position", value);
    }
 
    public Vector2 LastIncrement
    {
        get => (Vector2)_resource.Get("last_increment");
        set => _resource.Set("last_increment", value);
    }
 
    public Vector2 Direction
    {
        get => (Vector2)_resource.Get("direction");
        set => _resource.Set("direction", value);
    }
 
    public float Speed
    {
        get => (float)_resource.Get("speed");
        set => _resource.Set("speed", value);
    }
 
    public float Lifetime
    {
        get => (float)_resource.Get("lifetime");
        set => _resource.Set("lifetime", value);
    }
 
    public float AnimationLifetime
    {
        get => (float)_resource.Get("animation_lifetime");
        set => _resource.Set("animation_lifetime", value);
    }
 
    /// <summary>
    /// The physics shape RID used internally for collision queries.
    /// Typed as Rid (Godot's C# RID type).
    /// </summary>
    public Rid ShapeRid
    {
        get => (Rid)_resource.Get("shape_rid");
        set => _resource.Set("shape_rid", value);
    }
 
    /// <summary>
    /// The physics query parameters used internally for collision detection.
    /// Typed as Resource since PhysicsShapeQueryParameters2D is a Godot built-in
    /// and can be cast via .As&lt;PhysicsShapeQueryParameters2D&gt;() if needed.
    /// </summary>
    public Resource Query
    {
        get => _resource.Get("query").As<Resource>();
        set => _resource.Set("query", value);
    }

    #endregion
}
