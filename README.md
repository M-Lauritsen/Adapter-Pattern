# Adapter-Pattern

# What Is This Pattern?
The Adapter design pattern attempts to reconcile the differences between two otherwiseincompatible
interfaces. This pattern is especially useful when attempting to adapt to an
interface which cannot be refactored (e.g. when a particular interface is controlled by a web
service or API).

# The Participants
• The Target defines the domain-specific interface in use by the Client.
• The Client collaborates with objects which conform to the Target.
• The Adapter adapts the Adaptee to the Target.
• The Adaptee is the interface that needs adapting (i.e. the one that cannot be
refactored or changed).

# A Delicious Example
Vegetarians beware; for the Adapter design
pattern example, we're gonna cook some meat.
Lots of it.
Let's imagine that we maintain a meat safecooking
temperature database. The US Food &
Drug Administration maintains a list of
temperatures to which meat must be cooked
before it is safe for human consumption. We're
going to show how the Adapter design pattern
can be used to adapt an old, unchangeable API to
a new object-oriented system.

# Will I Ever Use This Pattern?
Most likely. As I've been mentioning, the pattern
is extremely useful when you're trying to adapt old
or legacy systems to new designs, so if you're ever
in that situation the Adapter pattern might be the
best fit for your project.

# Summary
The Adapter pattern attempts to reconcile two
incompatible interfaces, and is especially useful
when one or both of those interfaces cannot be
refactored.
