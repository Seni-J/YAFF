# Réalisation

## Problèmes rencontrés

### Structure globale du projet

Tout au long du projet, on était pas sûr de la structure de notre projet. On a hésité entre plusieurs moyens de faire et on est arrivé à un résultat qui fonctionne mais qui n'est pas le plus optimisé.

### Lecture dans les documents

On a perdu énormément de temps à essayer de lire à l'intérieur des fichiers de la mauvaise manière. On à commencer par utiliser "interop" qui était pas du tout adapter à notre besoin.

On s'est finalement tourné vers des petites librairies qui étaient beaucoup plus simple à utiliser.

### Optimisation

L'optimisation du projet n'a pas été simple à cause de l'implémentation effectuée au début. En effet, l'architecture qu'on avait imaginé n'était pas celle qu'on voulait et nous avons dû changer la structure après tout pour effacer des classes inutiles et réduire la taille du projet. Un autre problème était le temps de chargement de la liste qui prenait plus de 20 à 30 secondes pour plus de 10'000 fichiers. Nous avons réussi à régler le souci avec un workaround qui nous a permis de diviser ce temps de chargement par deux. 

## Bugs restants

### Chemin d'accès trop long 

Lorsque le chemin d'accès d'un dossier est plus grand que 255 caractères, l'application plante. C'est une erreur qui vient de Windows et que nous avons pas géré.

### Lecture d'un fichier Excel 

Lorsqu'on fait une recherche à l’intérieur d'un fichier excel. Si le fichier excel contient une formule . L'application plante. Nous n'avons pas géré l'erreur.

## Amélioration possible

* Refactorisation de certaines fonctions et/ou classes.
* Ajouter certains type de fichier à la recherche par mot clef comme par exemple : Les powerpoint ou les images.
* Améliorer la rapidité du programme \(Utilisation de LINQ\).
* Le rendre compatible avec MacOS / Linux.
* Régler les bugs actuels. 



