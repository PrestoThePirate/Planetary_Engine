using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace BaseGame
{
    public static class RequiredTypes
    {
        public static ComponentType[] PlayerBodyArchetype()
        {
            //EntityArchetype playerBodyArchetype = entityManager.CreateArchetype(
            //    typeof(LocalToWorld),
            //    typeof(Translation),
            //    typeof(Rotation),
            //    typeof(Child),
            //    typeof(Player),
            //    typeof(HasCameraTag)
            //    );

            //return playerBodyArchetype;
            ComponentType[] ArcheType = 
            {
                typeof(LocalToWorld),
                typeof(Translation),
                typeof(Rotation),
                typeof(Child),
                typeof(Player),
                typeof(HasCameraTag)
            };

            return ArcheType;

        }

        public static EntityArchetype CameraArchetype(EntityManager entityManager)
        {
            EntityArchetype cameraArchetype = entityManager.CreateArchetype(
                typeof(LocalToWorld),
                typeof(LocalToParent),
                typeof(Parent),
                typeof(PreviousParent),
                typeof(Translation),
                typeof(Rotation),
                typeof(MainCameraTag),
                typeof(HasBodyTag)
                );

            return cameraArchetype;
        }

    }
}


