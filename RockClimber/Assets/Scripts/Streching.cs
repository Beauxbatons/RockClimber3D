using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streching : MonoBehaviour
{
	public GameObject snapTarget;
	

	private float force = 600;
	private float damping = 6;

	Transform jointTrans;

	private void Start()
	{
		jointTrans = AttachJoint(gameObject.GetComponent<Rigidbody>(), gameObject.transform.position);
		
	}

	void Update()
	{
		if (snapTarget != null)
			jointTrans.position = snapTarget.transform.position;
	}
	Transform AttachJoint(Rigidbody rb, Vector3 attachmentPosition)
	{
		GameObject go = new GameObject("Attachment Point");
		go.hideFlags = HideFlags.HideInHierarchy;
		go.transform.position = attachmentPosition;

		var newRb = go.AddComponent<Rigidbody>();
		newRb.isKinematic = true;

		var joint = go.AddComponent<ConfigurableJoint>();
		joint.connectedBody = rb;
		joint.configuredInWorldSpace = true;
		joint.xDrive = NewJointDrive(force, damping);
		joint.yDrive = NewJointDrive(force, damping);
		joint.zDrive = NewJointDrive(force, damping);
		joint.slerpDrive = NewJointDrive(force, damping);
		joint.rotationDriveMode = RotationDriveMode.Slerp;

		return go.transform;
	}

	private JointDrive NewJointDrive(float force, float damping)
	{
		JointDrive drive = new JointDrive();
		//drive.mode = JointDriveMode.Position;
		drive.positionSpring = force;
		drive.positionDamper = damping;
		drive.maximumForce = Mathf.Infinity;
		return drive;
	}
}