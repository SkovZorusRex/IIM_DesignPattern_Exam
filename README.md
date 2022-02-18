# IIM_DesignPattern_Exam

## Mort du Personnage :
Création de la classe **SceneHandler**, contenant une méthode capable de rechargé le niveau actuel

## Ajout de l'habileté de défense
Création de la classe **EntityShield**, contenant 2 UnityEvent (OnShieldUp, OnShieldDown) bind au Start et Cancel du clique droit de la souris.
Les évenements modifie un booléen dans la classe **EntityFire** et **Health**

## Récupérer des objets
Création des classes **PickUp**, **Key** et **Potion** et de l'interface **IPickUp**.
**Key** utilise un UnityEvent
**Potion** utilise une PlayerReference

## Barre de vie et Player
Modification de la classe **DisplayHealth**, ajout du slider de la vie, la méthode modifiant l'affichage se fait grâce à un UnityAction sur lors des dégats reçus

## ObjectPool pour les Bullets
Création de la classe **BulletPool**, permettant l'object pooling de Bullet
Modification de **EntityFire** pour supporter l'ObjectPooling

## Events FX et SFX
Ajout d'une AudioSource et d'un ParticleSystem au Prefab de la Bullet (**NE FONCTIONNE PAS**)

## Interrupteur
Ajout de l'interface **ITouchable** à la classe **MyToggle**, la collision déclachant l'évenements OnToggleOn ou OnToggleOff
Création de la classe **GateWithToggle**, contentant un compteur interne augmenté ou diminué en fonction des évenements des Toggle

## Caisse
Ajout de l'interface **ITouchable** à la classe **Box**, la collision générant une valeur aléatoire entre 0 et 1 servant pour l'instantiation d'une potion

## Screen Shake
Création de **ControlShakeReference**, de **ControlShakeReferenceSetter** et du Scriptable **ControlShakeRef**
Ajout **ControlShakeReferenceSetter** à la VirtualCamera
Ajout d'une référence vers **ControlShakeRef** dans **Health**, permettant le CameraShake lors de dégâts subit

## Tests Unitaires
Utilisation de Linq
