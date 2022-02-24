using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;
    public TurretBlueprint laserBeamer;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }


    public void SelectMissleLauncher()
    {
        Debug.Log("MissleLauncher Selected");
        buildManager.SelectTurretToBuild(missleLauncher);

    }


    public void SelectLaserBeamer()
    {
        Debug.Log("LaserBeamer Selected");
        buildManager.SelectTurretToBuild(laserBeamer);

    }

}
