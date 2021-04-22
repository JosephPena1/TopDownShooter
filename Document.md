### Scripts:

**File**: GameManagerBehaviour.cs

**Functions**

    Name: Point
        Description: Gets & Sets _point
        Type: public float (Property)

    Name: GameOver
        Description: Gets _gameOver
        Type: public static bool (Property)

    Name: RestartGame()
        Description: Restarts the scene
        Type: public void

    Name: QuitGame()
        Description: Quits the application
        Type: public void

    Name: Update()
        Description: Update is called once per frame
        Type: void

**File**: HealthBehaviour.cs

**Functions**

    Name: Health
        Description: Gets _health
        Type: public float (Property)

    Name: TakeDamage(float damage)
        Description: Subtracts the given damage value from the health
        Type: public void

    Name: Update()
        Description: Update is called once per frame
        Type: void

**File**: OrbBehaviour.cs

**Functions**

    Name: Point
        Description: Sets _point for GameManager
        Type: public GameManagerBehaviour (Property)

    Name: Destroy()
        Description: Destroys the gameObject that called it
        Type: public void

    Name: OnTriggerEnter(Collider other)
        Description: Checks if an object enters the trigger
        Type: private void

**File**: OrbSpawnerBehaviour.cs

**Functions**

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: SpawnObjects()
        Description: Spawns orbs continuously while canSpawn is true
        Type: public IEnumerator

    Name: Update()
        Description: Update is called once per frame
        Type: private void

**File**: TurretShootBehaviour.cs

**Functions**

    Name: Target
        Description: Gets & Sets _target
        Type: public GameObject

    Name: Update()
        Description: Update is called once per frame
        Type: void

**File**: TurretSpawnerBehaviour.cs

**Functions**

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: SpawnObjects()
        Description: Spawns turrets continuously while canSpawn is true
        Type: public IEnumerator

    Name: Update()
        Description: Update is called once per frame
        Type: public void

**File**: BulletBehaviour.cs

**Functions**

    Name: Rigidbody
        Description: Gets _rigidbody
        Type: public Rigidbody (Property)

    Name: Damage
        Description: Gets & Sets _damage
        Type: public float (Property)

    Name: Awake()
        Description: 
        Type: private void

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: OnTriggerEnter(Collider other)
        Description: 
        Type: private void

**File**: BulletEmitterBehaviour.cs

**Functions**

    Name: Fire(Vector3 force)
        Description: Spawns a bullet and applies the given force
        Type: public void

**File**: PlayerMovementBehaviour.cs

**Functions**

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: FixedUpdate()
        Description: 
        Type: private void

**File**: CameraFollowBehaviour.cs

**Functions**

    Name: Update()
        Description: Update is called once per frame
        Type: void

**File**: HealthbarBehaviour.cs

**Functions**

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: Update()
        Description: Update is called once per frame
        Type: void

**File**: PointCounterBehaviour.cs

**Functions**

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: Update()
        Description: Update is called once per frame
        Type: void

**File**: TimerBehaviour.cs

**Functions**

    Name: Start()
        Description: Start is called before the first frame update
        Type: void

    Name: Update()
        Description: Update is called once per frame
        Type: void