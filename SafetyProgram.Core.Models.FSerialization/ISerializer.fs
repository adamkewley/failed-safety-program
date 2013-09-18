﻿module SafetyProgram.Core.Models.FSerialization.ConverterInterface

// Defines an interface for converting from one form to another
type IConverter<'a, 'b> =
    abstract member ConvertTo : 'a->Option<'b>
    abstract member ConvertFrom : 'b->Option<'a>