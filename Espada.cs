private Rigidbody2D rb;

void Awake()
{
	rb=GetComponent<Rigidbody2D>();
}

void Update()
{
	AsociarEspadaAlMouse();
}

private void AsociarEspadaAlMouse()
{
	var mousePosicion=Input.mousePosition;
	mousePosicion.z=10;
	
	rb.position=Camera.main.ScreenToWorldPoint(mousePosicion);
}
