using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class DoorTeleport : UdonSharpBehaviour
{
    [Tooltip("The point to teleport the player to")]
    public Transform teleportTarget;

    public override void Interact()
    {
        if (teleportTarget != null && Networking.LocalPlayer != null)
        {
            Networking.LocalPlayer.TeleportTo(
                teleportTarget.position,
                teleportTarget.rotation
            );
        }
    }
}    

