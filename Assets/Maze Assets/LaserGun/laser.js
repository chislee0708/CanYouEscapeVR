#pragma strict
var gun : GameObject;
var projectile : GameObject;

   function FixedUpdate()
    {
          
        var lr : LineRenderer = gameObject.GetComponent.<LineRenderer>();

         
      
 
        lr.SetPosition(0, gun.transform.position);
        lr.SetPosition(1, projectile.transform.position);
 
    }
