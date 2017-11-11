using System.Collections.Generic;
using UnityEngine;

public enum RegularEnum
{
    One,
    Two,
    Three
}

[System.Flags]
public enum EnumWithFlags
{
    Coke = 1 << 0,
    Hamburger = 1 << 1,
    Pizza = 1 << 2,
    Hotdog = 1 << 3,
    Pepsi = 1 << 4,
    Beer = 1 << 5,
    BuffaloWings = 1 << 6,
    IceCream = 1 << 7,
}

[System.Serializable]
public struct CustomType
{
    public int _int;

    [Range(0f, 1f)]
    public float _float;

    public Vector3 _vector3;

    public int[] _intArray;

    public Texture[] _textures;
}

[System.Serializable]
public class CustomTypeWithNameProperty
{
    public string _name;
}

// TODO(Matt): Add a lot more test types here, at least one per SerializedPropertyType
public class Tests : MonoBehaviour
{
    [Header("Non-array types")]
    public int _int;

    public int _float;

    public string _string;

    [Range(0f, 100f)]
    public float _floatWithRange;

    [HideInInspector]
    public float _hiddenField;

    [Header("Arrays")]

    public int[] _intArray;

    public float[] _floatArray;

    [Range(0.0f, 100.0f)]
    public float[] _floatArrayWithRange;

    public Texture[] _textures;


    [Header("Private fields")]

    [SerializeField]
    private List<RegularEnum> _enumArray;

    [SerializeField]
    private List<EnumWithFlags> _enumFlagsArray;

    [SerializeField]
    private LayerMask[] _layerMaskArray;

    [SerializeField]
    private CustomType _nestedData;

    [SerializeField]
    private CustomType[] _nestedDataArray;

    [SerializeField]
    private CustomTypeWithNameProperty[] _testNameProperty;

    // TODO(Matt): What is a mixer clip?
    [SerializeField]
    private AudioClip _mixerClip;

    [SerializeField]
    private AudioClip[] _mixerClipArray;
}
