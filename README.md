# Whipstaff

## Introduction

Whipstaff is a PoC library for designing a common UI library leveraging WPF, ReactiveUI and DHGMS Data Manager. It is written in C#

Whipstaff is a proof of concept around designing a common way of loading and handling a UI application (much like Job Helper is designed around batch processes). The concept is aimed towards enterprise development and reducing the amount of code reproduced whilst ensuring a reasonable amount of power and functionality in terms of group policy, system integrity checks, operating system versioning, etc.

As a concept it is aimed at leveraging:

* WPF
* .NET4
* ReactiveUI
* WPF NotifyIcon
* DHGMS Data Manager
* XUnit
* AvalonDock
* Multiple Monitors
* Group Policy and \ or Customer Policy Provider
* Support for features in Windows 8 (Desktop mode only) with graceful degradation to features of older operating systems where necessary
* Application Restart and Recovery
* System Integrity Checks to aid in Information Security
* Accessibility taking into account:
** Colour Blindness
** Dyslexia

This project is in an early stage so the design and \ or underlying libraries implementations may be volatile at points.

## Viewing the documentation

The documentation can be found at http://dhgms-solutions.github.com/whipstaff/

## Contributing to the code

### 1\. Fork the code

See the [github help page for instructions on how to create a fork](http://help.github.com/fork-a-repo/).

### 2\. Apply desired changes

Use your preffered method for carrying out work.

### 3\. Send a pull request

See the [github help page for instructions on how to send pull requests](http://help.github.com/send-pull-requests/)
