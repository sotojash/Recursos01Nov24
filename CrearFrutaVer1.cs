public GameObject prefabFrutaCortada;

public void CrearFrutaCortada()
{
	Instantiate(prefabFrutaCortada,transform.position,transform.rotation);
	Destroy(gameObject);
}

void Update()
{
	if(Input.GetKeyDown(KeyCode.Space))
	{
		CrearFrutaCortada();
	}
}
