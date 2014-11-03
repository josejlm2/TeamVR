#pragma strict

var speed = 2;
function Update ()
{
    if(Input.GetButtonDown("Fire1"))
    {
        if(speed > 0)
        {
            Physics.gravity = Vector3(0, speed, 0);
            speed = -2; 
                   
        }
        else
        {   
            Physics.gravity = Vector3(0, speed, 0);
            speed = 2;        
        }
    }
}
/*
function moveAll()
{   
    var objectsToEffect = GameObject.FindGameObjectsWithTag ("ObjectToEffect");
    for (var object in objectsToEffect) {
            object.Physics.gravity = Vector3(0, speed, 0);
    }  
}
*/