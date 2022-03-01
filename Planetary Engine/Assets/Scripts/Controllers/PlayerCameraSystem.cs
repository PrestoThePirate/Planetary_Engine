using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class PlayerCameraSystem : SystemBase
{

    //float mouseSensitivity = 20f;
    //float pitch = 0f;
    //float yaw = 0f;

    //protected override void OnUpdate()
    //{
    //    Entities.WithAll<MainCameraTag>().ForEach((Entity entity, ref Rotation rotation, in Parent parent) =>
    //    {

    //        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.DeltaTime;

    //        pitch -= mouseY;

    //        rotation.Value = quaternion.Euler(new float3(pitch, 0f, 0f));

    //    }).WithoutBurst().Run();

    //    Entities.WithAll<Player>().ForEach((Entity entity, ref Rotation rotation) =>
    //    {

    //        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.DeltaTime;

    //        yaw += mouseX;

    //        rotation.Value = quaternion.Euler(new float3(0f, yaw, 0f)); ;

    //    }).WithoutBurst().Run();
    //}
    protected override void OnUpdate()
    {
        
    }
}
