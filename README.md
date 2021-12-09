# Unity tutorial

## 1. Inspector - Some components
### Transform
- transform settings
### MeshFilter 
- renders something different than default mesh
### MeshRenderer
- settings for that render (texture,light...)
### BoxColider
- collision settings

## 2. Materials

-  Create subfolders in Assets folder
- create some materials (RC -> new material)
- drag it to some model

    
        MeshRenderer -> Materials -> Element 0 is now this material

## 3. Navigation

-  ```ALT + LEFT MOUSE``` :  rotate around
-  ```SHIFT + MIDDLE MOUSE``` :  pan around
-  ```MOUSE WHEEL``` :  zoom
-  ```SELECT OBJ + F``` :  focus on object
-  ```SELECT OBJ + CTRL + D``` :  copy object
-  ```CTRL + slide``` :  snap object movement
-  ```ALT + click on element in high.``` :  hide/expand children

## 4. Hierarchy

- ```PICK B -> DROP ON A``` :  A is parent of B

        You can now move B (child) independently, but not A.
        B is shown in inspector IN RELATIVE POSITION to parent.

## 5. Prefabs

-  Create subfolder Prefabs
- ```PICK A -> DROP IN FOLDER``` :  A is now PREFAB

        In hierarchy, that object is now blue (prefab).
- ```PICK prefab -> DROP TO SCENE``` : new objects are now new prefabs
### Organization   
- Create ```empty object``` for your prefabs (put position to 000)
### Editing prefabs (double click prefab) 
- remove unnecessary Box Coliders from children 

Overriding: 
- if you change something on a prefab``` instance```, it will turn ```bold```. Right click for ```revert/apply to all instances```
- on parent -> Overrides it shows ```list of all overrides```

## 6. Add player & physics
- create capsule
- Add component -> ```RigidBody```