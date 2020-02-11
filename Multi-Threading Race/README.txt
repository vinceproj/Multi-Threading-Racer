This program is meant to serve as an example of how interprocess communication functions. It creates up to three separate threads within the process to race each other to set the finished flag. Due to multi-threading and CPU time, the form will consistently display an excess of additional result prints after the flag setting event occurs. The program will tell the user which racer manages to set the flag, and the user may then search through that racer's history for the actual occurence.

Notables:
IPC
Multi-Threading
Flag Handling
Pseudo-Random Number Generators