#pragma strict
var level : String;
function OnTriggerEnter (other : Collider)
{
if (other.tag == "Player")
{
Application.LoadLevel("Map");
}
}