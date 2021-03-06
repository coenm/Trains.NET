﻿using Trains.NET.Engine;
using Xunit;

namespace Trains.NET.Tests
{
    public class CornerTests : TestBase
    {
        [Theory]
        [InlineData(180, 2, 2, 1, 1)]
        [InlineData(90, 1, 1, 2, 2)]
        public void RightUp_TrainMovement(float startAngle, int startColumn, int startRow, int endColumn, int endRow)
        {
            GameBoard.AddTrack(1, 1);
            GameBoard.AddTrack(1, 2);
            GameBoard.AddTrack(2, 2);

            AssertTrainMovement(startAngle, startColumn, startRow, endColumn, endRow);
        }

        [Theory]
        [InlineData(0, 1, 2, 2, 1)]
        [InlineData(90, 2, 1, 1, 2)]
        public void LeftUp_TrainMovement(float startAngle, int startColumn, int startRow, int endColumn, int endRow)
        {
            GameBoard.AddTrack(2, 1);
            GameBoard.AddTrack(2, 2);
            GameBoard.AddTrack(1, 2);

            AssertTrainMovement(startAngle, startColumn, startRow, endColumn, endRow);
        }

        [Theory]
        [InlineData(270, 1, 2, 2, 1)]
        [InlineData(180, 2, 1, 1, 2)]
        public void RightDown_TrainMovement(float startAngle, int startColumn, int startRow, int endColumn, int endRow)
        {
            GameBoard.AddTrack(2, 1);
            GameBoard.AddTrack(1, 1);
            GameBoard.AddTrack(1, 2);

            AssertTrainMovement(startAngle, startColumn, startRow, endColumn, endRow);
        }

        [Theory]
        [InlineData(0, 1, 1, 2, 2)]
        [InlineData(270, 2, 2, 1, 1)]
        public void LeftDown_TrainMovement(float startAngle, int startColumn, int startRow, int endColumn, int endRow)
        {
            GameBoard.AddTrack(1, 1);
            GameBoard.AddTrack(1, 2);
            GameBoard.AddTrack(2, 2);

            AssertTrainMovement(startAngle, startColumn, startRow, endColumn, endRow);
        }
    }
}
