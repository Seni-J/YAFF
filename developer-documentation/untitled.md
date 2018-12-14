# Réalisation

## Problèmes rencontrés

### Structure globale du projet

Tout au long du projet , on était pas sur de la structure de notre projet. On a hésité entre plusieurs moyen de faire et on est arrivé à un résultat qui fonctionne mais qui n'est pas le plus optimisé

### Lecture dans les documents

On a perdu énormément de temps à essayer de lire à l'intérieur des fichiers de la mauvaise manière. On à commencer par utiliser "interop" qui était pas du tout adapter à notre besoin.

On c'est finalement tourner vers des petites librairies qui étaient beaucoup plus simple à utilisé.

## Bugs restants

### Chemin d'accès trop long 

Lorsque le chemin d'accès d'un dossier est plus grand que 255 caractères, l'application plante. C'est une erreur qui vient de Windows et que nous avons pas gérer.

### Lecture d'un fichier excel 

Lorsqu'on fait une recherche à l’intérieur d'un fichier excel. Si le fichier excel contient une formule . L'application plante. Nous n'avons pas géré l'erreur.

## Amélioration possible

* Refactorisation de certaines fonctions et/ou classes
* Ajouter certains type de fichier à la recherche par mot clef comme par exemple : Les powerpoint ou les images
* Améliorer la rapidité du programme
* Le rendre compatible avec MacOS / Linux
* Régler les bugs actuels. 



