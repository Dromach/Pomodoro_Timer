# Pomodoro Timer

Un simple **Pomodoro Timer** en C# avec une interface graphique en WPF pour vous aider à gérer vos sessions de travail et de pause.

## Table des matières

- [Description](#description)
- [Installation](#installation)
- [Utilisation](#utilisation)

## Description

Ce projet implémente un **Pomodoro Timer**, un outil de gestion du temps basé sur la méthode Pomodoro, qui consiste à travailler pendant 25 minutes, suivi d'une pause de 5 minutes. Une fois la session de travail terminée, un nouveau cycle est démarré.

Le projet utilise **C#** et **WPF** pour l'interface utilisateur.

## Installation

### Prérequis

1. **.NET SDK** : Vous devez avoir le **.NET SDK** installé sur votre machine. Vous pouvez télécharger et installer la dernière version depuis [le site officiel de .NET](https://dotnet.microsoft.com/download).
2. **Visual Studio** ou **Visual Studio Code** avec les extensions C# et .NET Core.

### Étapes d'installation

1. Clonez le projet sur votre machine locale :
   ```bash
   git clone https://github.com/Dromach/Pomodoro_Timer.git
   ```

2. Restorez les dépendances :
   ```bash
   dotnet restore
   ```

3. Lancez le projet :
   ```bash
   dotnet run
   ```

## Utilisation

Lorsque vous lancez l'application, vous verrez l'interface graphique qui vous permet de démarrer une session de travail Pomodoro (25 minutes) et de prendre une pause (5 minutes).

- **Démarrer le timer** : Cliquez sur "Démarrer" pour commencer une session de travail de 25 minutes.
- **Pause** : Cliquez sur "Pause" pour suspendre le timer.
- **Reprendre** : Cliquez sur "Reprendre" pour reprendre là où vous vous êtes arrêté.
- **Arrêter** : Cliquez sur "Arrêter" pour réinitialiser le timer.
