using Godot;

/// <summary>
/// C# Wrapper around BulletType class (PerfBullets)
/// </summary>
public partial class BulletType : Resource
{
    private readonly GodotObject _resource;
 
    public BulletType(GodotObject resource)
    {
        if (resource == null)
            throw new System.ArgumentNullException(nameof(resource),
                "Resource is null — check your load path or Spawner reference.");
 
        if (!ClassDB.IsParentClass(resource.GetClass(), "Resource"))
            GD.PushWarning($"BulletType wrapper: expected a Resource, got {resource.GetClass()}");
 
        _resource = resource;
    }
 
    #region Properties
 
    /// <summary>Maps to set_animation_speed / get_animation_speed.</summary>
    public float AnimationSpeed
    {
        get => (float)_resource.Get("animation_speed");
        set => _resource.Set("animation_speed", value);
    }
 
    /// <summary>Maps to set_animation_lifetime / get_animation_lifetime.</summary>
    public float AnimationLifetime
    {
        get => (float)_resource.Get("animation_lifetime");
        set => _resource.Set("animation_lifetime", value);
    }
 
    public float InitialSpeed
    {
        get => (float)_resource.Get("initial_speed");
        set => _resource.Set("initial_speed", value);
    }
 
    public float MaxLifetime
    {
        get => (float)_resource.Get("max_lifetime");
        set => _resource.Set("max_lifetime", value);
    }
 
    /// <summary>
    /// The collision shape for bullets of this type.
    /// Typed as Resource since Shape2D subclasses are Godot built-ins
    /// and can be cast accordingly (e.g. .As&lt;CircleShape2D&gt;()).
    /// </summary>
    public Resource Shape
    {
        get => _resource.Get("shape").As<Resource>();
        set => _resource.Set("shape", value);
    }
 
    public float Acceleration
    {
        get => (float)_resource.Get("acceleration");
        set => _resource.Set("acceleration", value);
    }
 
    public float MinSpeed
    {
        get => (float)_resource.Get("min_speed");
        set => _resource.Set("min_speed", value);
    }
 
    public float MaxSpeed
    {
        get => (float)_resource.Get("max_speed");
        set => _resource.Set("max_speed", value);
    }
 
    /// <summary>Collision layer mask.</summary>
    public int Mask
    {
        get => (int)_resource.Get("mask");
        set => _resource.Set("mask", value);
    }
 
    public bool CollideWithBodies
    {
        get => (bool)_resource.Get("collide_with_bodies");
        set => _resource.Set("collide_with_bodies", value);
    }
 
    public bool CollideWithAreas
    {
        get => (bool)_resource.Get("collide_with_areas");
        set => _resource.Set("collide_with_areas", value);
    }
 
    public float Scale
    {
        get => (float)_resource.Get("scale");
        set => _resource.Set("scale", value);
    }
 
    public int NumberOfQueries
    {
        get => (int)_resource.Get("number_of_queries");
        set => _resource.Set("number_of_queries", value);
    }

    #endregion
}
