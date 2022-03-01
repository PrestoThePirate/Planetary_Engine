using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class CameraController : MonoBehaviour
{

    #region Singleton

    public static CameraController instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of CameraController found!");
            return;
        }

        instance = this;
    }

    #endregion

    public Entity CameraEntity;
    private EntityManager entityManager;
    public float3 positionOffSet = new float3(0,0,0);

    void Start()
    {

        EntityArchetype playerBodyArchetype = entityManager.CreateArchetype(BaseGame.RequiredTypes.PlayerBodyArchetype());

        Entity PlayerBody = entityManager.CreateEntity(playerBodyArchetype);

        CameraEntity = entityManager.CreateEntity(BaseGame.RequiredTypes.CameraArchetype(entityManager));

        entityManager.AddComponentData(CameraEntity, new Parent { Value = PlayerBody });

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        //Fixes the camera to an entites transfrom. ((POSITION + POSITIONOFFSET) + ROTATION)
        LocalToWorld localToWorld = entityManager.GetComponentData<LocalToWorld>(CameraEntity);

        transform.position = localToWorld.Position + positionOffSet;
        transform.rotation = localToWorld.Rotation;
    }

}
