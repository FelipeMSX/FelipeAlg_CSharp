﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms._interface
{
	interface ICommon<E>
	{
		bool IsFull();
		bool ISEmpty();

		E FirstItem();
		E LastItem();

		int Size();

	}
}